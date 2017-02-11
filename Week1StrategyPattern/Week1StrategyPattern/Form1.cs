using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1StrategyPattern
{
    public partial class Form1 : Form
    {
        //A list of requests, list of the labels that appear dinamically on the form and a label variable for further usage
        List<int> processlist; //list of requests
        List<Label> labels; // store list of labels to display next to trackbar
        private Label l; //to create a label dynamically
        bool checkDirectionForScan; //true if trackbar goes up, false if trackbar goes down

        IProcessMode imode;
        RequestList reqlist;
        public Form1()
        {
            InitializeComponent();

            checkDirectionForScan = true;
            processlist = new List<int>();
            labels = new List<Label>();

            Random r = new Random();
            for (int i = 0; i < 25; i++) //populate list
            {
                processlist.Add(r.Next(0, 100));
                lbToBeProcessed.Items.Add(processlist[processlist.Count-1]);
            }

            this.FillInLabels();

            numTimer.Value = trackbartimer.Interval;
            btRun.Enabled = false;
            btStop.Enabled = false;

            
        }

        //This method creates only one label and takes a request number as parameter
        private void CreateLabel(int number)
        {
            int height = trbViewprocess.Height;
            Point loc = trbViewprocess.Location;
            int a = loc.X + 50;
            int tickfreq = height / 100;
            int b = (loc.Y + height) - (tickfreq * number) - 20;

            l = new Label();
            l.Location = new Point(a, b);
            l.Text = number.ToString();
            l.Font = new Font("Arial", 6);
            l.Padding = new Padding(0, 0, 0, 0);


            labels.Add(l);
            this.Controls.Add(l);
            

             
        }

        //This method puts on the screen all labels corresponding to the requests
        private void FillInLabels()
        {
            foreach (int i in processlist)
            {
                CreateLabel(i);
            }
        }
        private void btRun_Click(object sender, EventArgs e)
        {
            trackbartimer.Start();
            btStop.Enabled = true;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            trackbartimer.Stop();
        }

      
        //This method controls labels: changes color or removes a label.
        //It also controls listbox activity and populates list with a random number after processing of one
        private void ControlLabels()
        {
            tbCurrentlyProcessed.Text = reqlist.Process().ToString();
            lbToBeProcessed.Items.Remove(reqlist.Process());

            for (int i = 0; i < labels.Count; i++)
                if (labels[i].Text == tbCurrentlyProcessed.Text)
                {

                    labels[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    labels[i].ForeColor = Color.Red;
                }
                else
                {
                    labels[i].Font = new Font("Arial", 6);
                    labels[i].ForeColor = Color.Black;
                }

            if (trbViewprocess.Value == Convert.ToInt32(tbCurrentlyProcessed.Text))
            {
                Random rnd = new Random();
                int toAdd = rnd.Next(0, 100);
                while (processlist.Contains(toAdd))
                {
                    toAdd = rnd.Next(0, 100);
                }
                processlist.Add(toAdd);

                for (int i = 0; i < labels.Count; i++)
                {
                    if (trbViewprocess.Value == Convert.ToInt32(labels[i].Text))
                    {
                        this.Controls.Remove(labels[i]);
                        processlist.Remove(Convert.ToInt32(tbCurrentlyProcessed.Text));
                    }
                }
                CreateLabel(processlist[processlist.Count - 1]);
                lbToBeProcessed.Items.Add(processlist[processlist.Count - 1]);
            }
        }

        private void trackbartimer_Tick(object sender, EventArgs e)
        {
            

            if (trbViewprocess.Value == trbViewprocess.Minimum)
            {
                checkDirectionForScan = true;
                if (imode is ModeScan)
                {
                    ((ModeScan)imode).checkdirection = checkDirectionForScan;
                }
            }
            else if (trbViewprocess.Value == trbViewprocess.Maximum)
            {
                checkDirectionForScan = false;
                if (imode is ModeScan)
                {
                    ((ModeScan)imode).checkdirection = checkDirectionForScan;
                }
            }

            ControlLabels();
            trbViewprocess.Value = reqlist.processmode.GetTrackBarValue(trbViewprocess.Value, trbViewprocess.Maximum, Convert.ToInt32(tbCurrentlyProcessed.Text), checkDirectionForScan);

        }

        private void rbSeekTime_CheckedChanged(object sender, EventArgs e)
        {
            imode = new ModeShortSeekTime(processlist, trbViewprocess.Value);
            reqlist = new ReqListCurrent(imode);
            btRun.Enabled = true;
        }

        private void rbFirstInFirstOut_CheckedChanged(object sender, EventArgs e)
        {
            imode = new ModeFirstInFirstOut(processlist);
            reqlist = new ReqListCurrent(imode);
            btRun.Enabled = true;
        }

        private void rbScan_CheckedChanged(object sender, EventArgs e)
        {
            imode = new ModeScan(processlist, trbViewprocess.Value, checkDirectionForScan);
            reqlist = new ReqListCurrent(imode);
            btRun.Enabled = true;
        }

        private void rbCScan_CheckedChanged(object sender, EventArgs e)
        {
            imode = new ModeCScan(processlist, trbViewprocess.Value);
            reqlist = new ReqListCurrent(imode);
            btRun.Enabled = true;
        }

        private void rbCLook_CheckedChanged(object sender, EventArgs e)
        {
            imode = new ModeCLook(processlist, trbViewprocess.Value);
            reqlist = new ReqListCurrent(imode);
            btRun.Enabled = true;
        }

        private void btSetTimer_Click(object sender, EventArgs e)
        {
            trackbartimer.Interval = Convert.ToInt32(numTimer.Value);
        }

       
    }
}
