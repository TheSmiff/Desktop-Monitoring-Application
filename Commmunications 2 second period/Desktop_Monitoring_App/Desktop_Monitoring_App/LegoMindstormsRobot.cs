using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;
using System.Diagnostics;

namespace Desktop_Monitoring_App
{
    class LegoMindstormsRobot
    {
        #region Variables
        //Lists to retain past data
        private List<int> xCoordinate = new List<int>();
        private List<int> yCoordinate = new List<int>();
        private List<int> theta = new List<int>();
        private List<int> velocity = new List<int>();
        private List<int> battery = new List<int>();
        Stopwatch sw = new Stopwatch();

        //Pointpairlists for Zedgraph plotting
        private PointPairList plotBattery = new PointPairList();
        #endregion

        #region Properties
        public List<int> XCoordinate
        {
            get { return xCoordinate; }
            set { xCoordinate = value; }
        }

        public List<int> YCoordinate
        {
            get { return yCoordinate; }
            set { yCoordinate = value; }
        }

        public List<int> Theta
        {
            get { return theta; }
            set { theta = value; }
        }

        public List<int> Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public List<int> Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public PointPairList PlotBattery
        {
            get { return plotBattery; }
            set { plotBattery = value; }
        }
        #endregion

        #region Constructors
        //Constructor for when Lists are available
        public LegoMindstormsRobot(List<int> X, List<int> Y, List<int> Theta, List<int> Vel, List<int> Batt)
        {
            xCoordinate = X;
            yCoordinate = Y;
            theta = Theta;
            velocity = Vel;
            battery = Batt;

            plotBattery = new PointPairList();
        }

        //Constructor for when only single values are available
        public LegoMindstormsRobot(int X, int Y, int Theta, int Vel, int Batt)
        {
            xCoordinate.Add(X);
            yCoordinate.Add(Y);
            theta.Add(Theta);
            velocity.Add(Vel);
            battery.Add(Batt);

            plotBattery = new PointPairList();
        }

        //Default Constructor
        public LegoMindstormsRobot()
        {
            xCoordinate = new List<int>();
            yCoordinate = new List<int>();
            theta = new List<int>();
            velocity = new List<int>();
            battery = new List<int>();

            plotBattery = new PointPairList();
        }
        #endregion

        #region Methods

        public void AddToGraph(int value)
        {
            if (sw.IsRunning == false)
            {
                sw.Start();
            }

            plotBattery.Add(sw.Elapsed.TotalSeconds, value);

        }

        #endregion
    }
}
