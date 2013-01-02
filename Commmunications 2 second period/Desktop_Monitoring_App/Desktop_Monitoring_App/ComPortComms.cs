using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Collections;

//http://www.dreamincode.net/forums/topic/35775-serial-port-communication-in-c%23/
namespace Desktop_Monitoring_App
{
    class ComPortComms
    {
        #region Variables and enums
        //enum for message types to colour comm port data
        public enum MessageType { Incoming, Outgoing, Normal, Warning, Error };
        //property variables - strings initialised to avoid nullexceptions
        private string portName = string.Empty;
        private string baudRate = string.Empty;
        private string flowControl = string.Empty;
        private string parityBits = string.Empty;
        private string stopBits = string.Empty;
        private string dataBits = string.Empty;
        //Other variables
        private bool connected = false;
        private RichTextBox rawComms;
        private SerialPort xbee = new SerialPort();
        //enum for text type to display
        public enum DisplayTypes { Text, Hex, Data }
        private DisplayTypes displayType;
        //Colors for MessageType Enum
        private Color[] Colors = { Color.Green, Color.Blue, Color.Black, Color.Orange, Color.Red };
        //For statistics and details
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

        public RichTextBox RawComms
        {
            get { return rawComms; }
            set { rawComms = value; }
        }

        public DateTime TimeOpened
        {
            get { return timeOpened; }
            set { timeOpened = value; }
        }

        public bool Connected
        {
            get { return connected; }
            set { connected = value; }
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

        #region Constructors
        //Constructor for values given
        public ComPortComms(string port, string baud, string flow, string parity, string stop, string data, RichTextBox box)
        {
            portName = port;
            baudRate = baud;
            flowControl = flow;
            parityBits = parity;
            stopBits = stop;
            dataBits = data;
            rawComms = box;
            xbee.DataReceived += new SerialDataReceivedEventHandler(xbee_DataReceived);
            
            
        }

        //Constructor for when no values present
        public ComPortComms()
        {
            portName = "COM1";
            rawComms = null;
            xbee.DataReceived +=new SerialDataReceivedEventHandler(xbee_DataReceived);
        }
        #endregion

        #region Methods

        //Data Recieved Event Handler
        void xbee_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            switch(DisplayType)
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
                    break;

                default:
                    string incoming = xbee.ReadExisting();
                    DisplayData(MessageType.Warning, "Message Type Not Found, Displaying as Text\n");
                    DisplayData(MessageType.Incoming, incoming + "\n");
                    break;
            }
        }

        //Method used in this class to update the Rich Text Box on the form
        //Method taken from http://www.dreamincode.net/forums/topic/35775-serial-port-communication-in-c%23/
        [STAThread]
        public void DisplayData(MessageType type, string msg)
        {
            rawComms.Invoke(new EventHandler(delegate
            {
                rawComms.SelectedText = string.Empty;
                rawComms.SelectionFont = new Font(rawComms.SelectionFont, FontStyle.Bold);
                rawComms.SelectionColor = Colors[(int)type];
                rawComms.AppendText(msg);
                rawComms.ScrollToCaret();
            }));
        }

        //Request Port Open
        public bool Open()
        {
            try
            {
                //if the port is already open, close and reopen
                if (xbee.IsOpen == true)
                {
                    xbee.Close();
                }

                //Setup the properties
                xbee.PortName = portName;
                xbee.BaudRate = int.Parse(baudRate);
                xbee.Handshake = (Handshake)Enum.Parse(typeof(Handshake), flowControl);
                xbee.Parity = (Parity)Enum.Parse(typeof(Parity), parityBits);
                xbee.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits);
                xbee.DataBits = int.Parse(dataBits);

                //Now open the comm port
                xbee.Open();
                TimeOpened = DateTime.Now;
                DisplayData(MessageType.Normal, xbee.PortName + " opened at " + DateTime.Now + "\n");
                Connected = true;
                return true;
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, ex.Message);
                Connected = false;
                return false;
            }
        }

        //Request Port Close
        public bool Close()
        {
            try
            {
                xbee.Close();
                Connected = false;
                DisplayData(MessageType.Normal, xbee.PortName + " closed at " + DateTime.Now + "\n");
                DisplayData(MessageType.Normal, "Connected for " + (DateTime.Now - TimeOpened).ToString() +"\n");
                return true;
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, ex.Message);
                Connected = true;
                return false;
            }
        }

        //Populate ComboBoxes
        

        //Serial String Write
        public void Write(string Data)
        {
            if (!(xbee.IsOpen == true))
            {
                xbee.Open();
            }
            xbee.Write(Data);
            DisplayData(MessageType.Outgoing, Data + "\n");
        }

        //Serial Byte Write
        public void Write(byte[] Data)
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

        //Converts a string containing Hex data to a byte array
        //Method taken from http://www.dreamincode.net/forums/topic/35775-serial-port-communication-in-c%23/
        public byte[] HexToByte(string msg)
        {
            //remove any spaces from the string
            msg = msg.Replace(" ", "");
            //create a byte array the length of the
            //divided by 2 (Hex is 2 characters in length)
            byte[] comBuffer = new byte[msg.Length / 2];
            //loop through the length of the provided string
            for (int i = 0; i < msg.Length; i += 2)
                //convert each set of 2 characters to a byte
                //and add to the array
                comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
            //return the array
            return comBuffer;
        }

        //Converts a byte array to string data for display
        //Method taken from http://www.dreamincode.net/forums/topic/35775-serial-port-communication-in-c%23/
        public string ByteToHex(byte[] comByte)
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

        #endregion
    }
}
