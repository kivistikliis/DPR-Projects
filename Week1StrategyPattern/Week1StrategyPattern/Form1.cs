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
        List<int> processlist;
        List<Label> labels;
        private Label l;

        IProcessMode fi;
        RequestList lfi;
        public Form1()
        {
            InitializeComponent();
            
            processlist = new List<int>();

            labels = new List<Label>();
            Random r = new Random();

            for (int i = 0; i < 15; i++)
            {
                processlist.Add(r.Next(0, 100));
                lbToBeProcessed.Items.Add(processlist[processlist.Count-1]);
            }

            this.FillInLabels();
        }

        //This method created only one label and takes a request number as parameter
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
            l.Font = new Font("Arial", 8);
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
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            trackbartimer.Stop();
        }

        //This method chooses the direction of the trackbar
        private void TrackBarDirection(int currentNumber,int nextNumber)
        {
            if (nextNumber>currentNumber)
                trbViewprocess.Value++;
            else
                trbViewprocess.Value--;
        }

        private void trackbartimer_Tick(object sender, EventArgs e)
        { 
            if (rbFirstInFirstOut.Checked)
            {

                tbCurrentlyProcessed.Text = lfi.Process().ToString();
                if (trbViewprocess.Value.ToString() == tbCurrentlyProcessed.Text)
                    lbToBeProcessed.Items.Remove(Convert.ToInt32(tbCurrentlyProcessed.Text));

                for (int i = 0; i < labels.Count; i++)
                    if (labels[i].Text == tbCurrentlyProcessed.Text)
                    {
                        
                        labels[i].Font = new Font("Arial", 12, FontStyle.Bold);
                        labels[i].ForeColor = Color.Red;
                    }
                    else
                    {
                        labels[i].Font = new Font("Arial", 8);
                        labels[i].ForeColor = Color.Black;
                    }

                if (trbViewprocess.Value == Convert.ToInt32(tbCurrentlyProcessed.Text))
                {
                    
                    
                    for (int i = 0; i < labels.Count; i++)
                        if (labels[i].Text == trbViewprocess.Value.ToString())
                        {
                            this.Controls.Remove(labels[i]);
                        }
                    
                    Random rnd = new Random();
                    processlist.Add(rnd.Next(0, 100));
                    processlist.Remove(Convert.ToInt32(tbCurrentlyProcessed.Text));
                    CreateLabel(processlist[processlist.Count - 1]);
                    lbToBeProcessed.Items.Add(processlist[processlist.Count - 1]);
                }
            }
            else
                if(rbSeekTime.Checked)
                {
                    fi = new ShortSeekTime(processlist,trbViewprocess.Value);
                    lfi = new ReqListFIFO(fi);

                    tbCurrentlyProcessed.Text = lfi.Process().ToString();
                    if (trbViewprocess.Value.ToString() == tbCurrentlyProcessed.Text)
                        lbToBeProcessed.Items.Remove(Convert.ToInt32(tbCurrentlyProcessed.Text));

                    for (int i = 0; i < labels.Count; i++)
                        if (labels[i].Text == tbCurrentlyProcessed.Text)
                        {

                            labels[i].Font = new Font("Arial", 12, FontStyle.Bold);
                            labels[i].ForeColor = Color.Red;
                        }
                        else
                        {
                            labels[i].Font = new Font("Arial", 8);
                            labels[i].ForeColor = Color.Black;
                        }

                    
                    if (trbViewprocess.Value == Convert.ToInt32(tbCurrentlyProcessed.Text))
                    {

                        for (int i = 0; i < labels.Count; i++)
                            if (labels[i].Text == trbViewprocess.Value.ToString())
                            {
                                this.Controls.Remove(labels[i]);
                            }

                        Random rnd = new Random();
                        processlist.Add(rnd.Next(0, 100));

                        processlist.Remove(Convert.ToInt32(tbCurrentlyProcessed.Text));
                        CreateLabel(processlist[processlist.Count - 1]);
                        lbToBeProcessed.Items.Add(processlist[processlist.Count - 1]);
                    }
                }


        TrackBarDirection(trbViewprocess.Value, Convert.ToInt32(tbCurrentlyProcessed.Text));
        }

        private void rbSeekTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFirstInFirstOut_CheckedChanged(object sender, EventArgs e)
        {
            fi = new FirstInFirstOut(processlist);
            lfi = new ReqListFIFO(fi);
        }
    }
}
