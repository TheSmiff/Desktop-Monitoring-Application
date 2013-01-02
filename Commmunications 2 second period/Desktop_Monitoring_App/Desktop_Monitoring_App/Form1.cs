using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using ZedGraph;

//http://www.dreamincode.net/forums/topic/35775-serial-port-communication-in-c%23/
//http://www.codeproject.com/Articles/5431/A-flexible-charting-library-for-NET
namespace Desktop_Monitoring_App
{
    public delegate void ListUpdated();
    public partial class Form1 : Form
    {
        //ComPortComms comms = new ComPortComms();
        #region Variables and Enums
        LegoMindstormsRobot Robot1 = new LegoMindstormsRobot();
        LegoMindstormsRobot Robot2 = new LegoMindstormsRobot();
        LegoMindstormsRobot Robot3 = new LegoMindstormsRobot();

        SerialPort xbee = new SerialPort();

        public enum DisplayTypes { Text, Hex, Data };
        public enum MessageType { Incoming, Outgoing, Normal, Warning, Error };
        private Color[] Colors = { Color.Green, Color.Blue, Color.Black, Color.Orange, Color.Red };

        private string portName = string.Empty;
        private string baudRate = string.Empty;
        private string flowControl = string.Empty;
        private string parityBits = string.Empty;
        private string stopBits = string.Empty;
        private string dataBits = string.Empty;
        private DisplayTypes displayType;
        private DateTime timeOpened;
        private List<byte> receivedData = new List<byte>();
        #endregion

        #region Properties
        public string PortName
        {
            get { return portName; }
            set { portName = value; }
        }

        public string BaudRate
        {
            get { return baudRate; }
            set { baudRate = value; }
        }

        public string FlowControl
        {
            get { return flowControl; }
            set { flowControl = value; }
        }

        public string ParityBits
        {
            get { return parityBits; }
            set { parityBits = value; }
        }

        public string StopBits
        {
            get { return stopBits; }
            set { stopBits = value; }
        }

        public string DataBits
        {
            get { return dataBits; }
            set { dataBits = value; }
        }

        public DateTime TimeOpened
        {
            get { return timeOpened; }
            set { timeOpened = value; }
        }

        public DisplayTypes DisplayType
        {
            get { return displayType; }
            set { displayType = value; }
        }

        public List<byte> ReceivedData
        {
            get { return receivedData; }
            set { receivedData = value; }
        }
        #endregion

        #region Form Constructor
        public Form1()
        {
            InitializeComponent();
        }

        //Actions to complete Form upon loading
        public void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxLoadValues(comboBox_Port, comboBox_Flow, comboBox_Parity, comboBox_Stop);

            comboBox_Baud.SelectedText = "115200";
            comboBox_Data.SelectedText = "8";
            comboBox_Flow.SelectedIndex = 0;
            comboBox_Parity.SelectedIndex = 0;
            comboBox_Stop.SelectedIndex = 1;
            if (comboBox_Port.Items.Contains("COM13"))
            {
                comboBox_Port.SelectedText = "COM13";
            }
            else
            {
                comboBox_Port.SelectedIndex = 0;
            }

            pictureBox_Status.Image = Image.FromFile("./Images/not_connected.png");
            button_Query.Enabled = false;
        }
        #endregion

        #region Methods

        #region Generic
        //Serial String Write
        private void Send(string Data)
        {
            if (!(xbee.IsOpen == true))
            {
                xbee.Open();
            }
            xbee.Write(Data);
            DisplayData(MessageType.Outgoing, Data + "\n");
        }

        //Serial Byte Write
        private void Send(byte[] Data)
        {
            if (!(xbee.IsOpen == true))
            {
                xbee.Open();
            }
            xbee.Write(Data, 0, Data.Length);
            if (DisplayType != DisplayTypes.Data)
            {
                DisplayData(MessageType.Outgoing, ByteToHex(Data) + "\n");
            }
        }

        private void ComboBoxLoadValues(object Ports, object Flow, object Parity, object Stop)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                ((ComboBox)Ports).Items.Add(s);
            }

            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                ((ComboBox)Flow).Items.Add(s);
            }

            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                ((ComboBox)Parity).Items.Add(s);
            }

            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                ((ComboBox)Stop).Items.Add(s);
            }
        }

        //Method used in this class to update the Rich Text Box on the form
        //Method taken from http://www.dreamincode.net/forums/topic/35775-serial-port-communication-in-c%23/
        [STAThread]
        private void DisplayData(MessageType type, string msg)
        {
            richTextBox_RawComms.Invoke(new EventHandler(delegate
            {
                richTextBox_RawComms.SelectedText = string.Empty;
                richTextBox_RawComms.SelectionFont = new Font(richTextBox_RawComms.SelectionFont, FontStyle.Bold);
                richTextBox_RawComms.SelectionColor = Colors[(int)type];
                richTextBox_RawComms.AppendText(msg);
                richTextBox_RawComms.ScrollToCaret();
            }));
        }

        //Data Recieved Event Handler
        void xbee_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            switch (DisplayType)
            {
                case DisplayTypes.Text:
                    string incomingData = xbee.ReadExisting();
                    DisplayData(MessageType.Incoming, incomingData + "\n");
                    break;

                case DisplayTypes.Hex:
                    byte[] buffer = new byte[xbee.BytesToRead];
                    xbee.Read(buffer, 0, buffer.Length);
                    DisplayData(MessageType.Incoming, ByteToHex(buffer) + "\n");
                    break;

                case DisplayTypes.Data:
                    byte[] buffer2 = new byte[xbee.BytesToRead];
                    xbee.Read(buffer2, 0, buffer2.Length);
                    foreach (byte b in buffer2)
                    {
                        ReceivedData.Add(b);
                    }
                    DisplayData(MessageType.Incoming, ByteToHex(buffer2) + "\n");
                    UpdateLego(buffer2);
                    break;

                default:
                    string incoming = xbee.ReadExisting();
                    DisplayData(MessageType.Warning, "Message Type Not Found, Displaying as Text\n");
                    DisplayData(MessageType.Incoming, incoming + "\n");
                    break;
            }
        }

        [STAThread]
        private void UpdateLego(byte[] received)
        {
            byte[] XPos = new byte[2];
            byte[] YPos = new byte[2];
            byte[] Light = new byte[2];
            byte[] Sound = new byte[2];

            try
            {
                Array.Copy(received, 3, XPos, 0, 2);
                Array.Copy(received, 5, YPos, 0, 2);
                Array.Copy(received, 7, Light, 0, 2);
                Array.Copy(received, 1, Sound, 0, 2);
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, ex.Message);
            }

            switch (received[0])
            {
                case 0x77:
                    label_R1TagData.Invoke(new EventHandler (delegate { label_R1TagData.Text = "0x77"; }));
                    label_R1XPosData.Invoke(new EventHandler(delegate { label_R1XPosData.Text = ByteToInt(XPos).ToString(); }));
                    label_R1YPosData.Invoke(new EventHandler(delegate { label_R1YPosData.Text = ByteToInt(YPos).ToString(); }));
                    label_R1LRData.Invoke(new EventHandler  (delegate { label_R1LRData.Text = ByteToInt(Light).ToString(); }));
                    label_R1SRData.Invoke(new EventHandler  (delegate { label_R1SRData.Text = ByteToInt(Sound).ToString(); }));
                    break;

                case 0x46:
                    label_R2TagData.Invoke(new EventHandler (delegate { label_R2TagData.Text = "0x46"; }));
                    label_R2XPosData.Invoke(new EventHandler(delegate { label_R2XPosData.Text = ByteToInt(XPos).ToString(); }));
                    label_R2YPosData.Invoke(new EventHandler(delegate { label_R2YPosData.Text = ByteToInt(YPos).ToString(); }));
                    label_R2LRData.Invoke(new EventHandler  (delegate { label_R2LRData.Text = ByteToInt(Light).ToString(); }));
                    label_R2SRData.Invoke(new EventHandler  (delegate { label_R2SRData.Text = ByteToInt(Sound).ToString(); }));

                    break;

                case 0x5C:
                    label_R3TagData.Invoke(new EventHandler (delegate { label_R3TagData.Text = "0x5C"; }));
                    label_R3XPosData.Invoke(new EventHandler(delegate { label_R3XPosData.Text = ByteToInt(XPos).ToString(); }));
                    label_R3YPosData.Invoke(new EventHandler(delegate { label_R3YPosData.Text = ByteToInt(YPos).ToString(); }));
                    label_R3LRData.Invoke(new EventHandler  (delegate { label_R3LRData.Text = ByteToInt(Light).ToString(); }));
                    label_R3SRData.Invoke(new EventHandler  (delegate { label_R3SRData.Text = ByteToInt(Sound).ToString(); }));

                    break;
            }
        }
        #endregion

        #region Button Event Handlers
        //Connects with given values
        private void button_Connect_Click(object sender, EventArgs e)
        {
            PortName = comboBox_Port.Text;
            BaudRate = comboBox_Baud.Text;
            FlowControl = comboBox_Flow.Text;
            ParityBits = comboBox_Parity.Text;
            StopBits = comboBox_Stop.Text;
            DataBits = comboBox_Data.Text;

            try
            {
                //if the port is already open, close and reopen
                if (xbee.IsOpen == true)
                {
                    xbee.Close();
                }

                //Setup the properties
                xbee.PortName = PortName;
                xbee.BaudRate = int.Parse(BaudRate);
                xbee.Handshake = (Handshake)Enum.Parse(typeof(Handshake), flowControl);
                xbee.Parity = (Parity)Enum.Parse(typeof(Parity), parityBits);
                xbee.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits);
                xbee.DataBits = int.Parse(dataBits);

                //Now open the comm port
                xbee.Open();
                TimeOpened = DateTime.Now;
                DisplayData(MessageType.Normal, xbee.PortName + " opened at " + DateTime.Now + "\n");
                pictureBox_Status.Image = Image.FromFile("./Images/connected.png");
                xbee.DataReceived += new SerialDataReceivedEventHandler(xbee_DataReceived);
                checkBox_Hex.Enabled = true;
                button_Connect.Enabled = false;
                button_Disconnect.Enabled = true;
                button_Query.Enabled = true;
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, ex.Message);
            }
        }

        //Disconnect From Comm Port
        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                xbee.Close();
                DisplayData(MessageType.Normal, xbee.PortName + " closed at " + DateTime.Now + "\n");
                DisplayData(MessageType.Normal, "Connected for " + (DateTime.Now - TimeOpened).ToString() + "\n");
                pictureBox_Status.Image = Image.FromFile("./Images/not_connected.png");
                button_Connect.Enabled = true;
                button_Disconnect.Enabled = false;
                checkBox_Hex.Enabled = false;
                xbee.DataReceived -= xbee_DataReceived;
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, ex.Message);
            }
        }

        //Clears Rich Text Box
        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_RawComms.Clear();
        }

        //Confirms and tests Xbee connection and gets Xbee info
        private void button_Query_Click(object sender, EventArgs e)
        {
            //Enter AT command mode (1 second delay required before next command)
            Send("+++");
            Thread.Sleep(1001);
            //Request Baud Rate and wait for data back -> expected 7
            Send("ATBD\r");
            Thread.Sleep(15);
            //Request PAN ID
            Send("ATID\r");
            Thread.Sleep(20);
            //Request Zigbee Channel
            Send("ATCH\r");
            Thread.Sleep(20);
            //Request Hi Serial Number
            Send("ATSH\r");
            Thread.Sleep(20);
            //Request Lo Serial Number
            Send("ATSL\r");
            Thread.Sleep(20);
            //Request Firmware Version -> Coordinator 1020, Router/End 1220
            Send("ATVR\r");
            Thread.Sleep(20);
            //Request D7 Status -> Expected reply 7
            Send("ATD7\r");
            Thread.Sleep(10);
            //Request 16bit serial address
            Send("ATMY\r");
            Thread.Sleep(20);
            Send("ATND\r");
            Thread.Sleep(500);
            //Exit AT Command Mode -> reply OK
            Send("ATCN\r");
        }

        //Change how data is displayed in the terminal, either hex or string data
        private void checkBox_Hex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Hex.Checked)
            {
                DisplayType = DisplayTypes.Hex;
                DisplayData(MessageType.Normal, "Display Type Hex\n");
            }
            else
            {
                DisplayType = DisplayTypes.Text;
                DisplayData(MessageType.Normal, "Display Type Text\n");
            }
        }

        private void button_Log_Click(object sender, EventArgs e)
        {
            if (button_Log.Text == "Start Logging")
            {
                DisplayType = DisplayTypes.Data;
                DisplayData(MessageType.Normal, "Started Data Logging at " + DateTime.Now.ToString() + "\n");
                Send(HexToByte("FF000000000000000000"));
                button_Log.Text = "Stop Logging";
            }
            else if (button_Log.Text == "Stop Logging")
            {
                DisplayType = DisplayTypes.Hex;
                DisplayData(MessageType.Normal, "Stopped Data Logging at " + DateTime.Now.ToString() + "\n");
                Send(HexToByte("FF000000000000000000"));
                button_Log.Text = "Start Logging";
            }
            
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (textBox_Send.Text.Length > 0)
            {
                Send(textBox_Send.Text);
                textBox_Send.Clear();
            }
            else if (textBox_SendHex.Text.Length > 0)
            {
                byte[] Msg = HexToByte(textBox_SendHex.Text);
                Send(Msg);
                textBox_SendHex.Clear();
            }
        }
        #endregion

        #region Hex Methods
        //Converts a string containing Hex data to a byte array
        //Method taken from http://www.dreamincode.net/forums/topic/35775-serial-port-communication-in-c%23/
        private byte[] HexToByte(string msg)
        {
            //remove any spaces from the string
            msg = msg.Replace(" ", "");
            //create a byte array the length of the
            //divided by 2 (Hex is 2 characters in length)
            byte[] comBuffer = new byte[msg.Length / 2];
            //loop through the length of the provided string
            for (int i = 0; i < msg.Length; i += 2)
            {
                //convert each set of 2 characters to a byte
                //and add to the array
                try
                {
                    comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
                }
                catch (Exception ex)
                {
                    DisplayData(MessageType.Error, "Message Not Sent, Conversion Error " + DateTime.Now.ToString());
                    DisplayData(MessageType.Error, ex.Message);
                }
            }
            //return the array
            return comBuffer;
        }

        //Converts a byte array to string data for display
        //Method taken from http://www.dreamincode.net/forums/topic/35775-serial-port-communication-in-c%23/
        private string ByteToHex(byte[] comByte)
        {
            //create a new StringBuilder object
            StringBuilder builder = new StringBuilder(comByte.Length * 3);
            //loop through each byte in the array
            foreach (byte data in comByte)
                //convert the byte to a string and add to the stringbuilder
                builder.Append(Convert.ToString(data, 16).PadLeft(2, '0').PadRight(3, ' '));
            //return the converted value
            return builder.ToString().ToUpper();
        }

        //Converts a byte array recieved from the Lego Robots via XBee
        //and converts the hex data to a decimal integer.
        private int ByteToInt(byte[] received)
        {
            int Dec = 0;
            int Power = 0;
            for (int i = 0; i < received.Length; i++)
            {
                Dec += Convert.ToInt32(received[i]) * (int)(Math.Pow(16, Power));
                Power += 2;
            }
            return Dec;
        }
        #endregion

        
        #endregion
    }
}
