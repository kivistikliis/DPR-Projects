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
        private int counter=-1;
        List<int> processlist;
        List<Label> labels;
        private Label l;

        IProcessMode fi;
        RequestList lfi;
        public Form1()
        {
            InitializeComponent();
            
            processlist = new List<int>();
            fi = new FirstInFirstOut(processlist);
            lfi = new ReqListFIFO(fi);

            labels = new List<Label>();
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                processlist.Add(r.Next(0, 100));
            }

            foreach (int i in processlist)
            {
                lbToBeProcessed.Items.Add(i);
            }
            
        }

        private void CreateLabel(int number)
        {
            int height = trbViewprocess.Height;
            Point loc = trbViewprocess.Location;
            int a = loc.X + 50;
            int tickfreq = height / 100;

            l = new Label();
                int b = (loc.Y + height) - (tickfreq * number) - 20;

                l.Location = new Point(a, b);
                l.Text = number.ToString();
                l.Font = new Font("Arial", 8);
                l.Padding = new Padding(0, 0, 0, 0);
                labels.Add(l);
                this.Controls.Add(l);
        }
        private void FillInLabels()
        {
            foreach (int i in processlist)
            {
                CreateLabel(i);
            }
        }
        private void btRun_Click(object sender, EventArgs e)
        {
            this.FillInLabels();
            trackbartimer.Start();

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            

        }

        private void trbViewprocess_Scroll(object sender, EventArgs e)
        {
            tbCurrentlyProcessed.Text = trbViewprocess.Value.ToString();
        }
        private void TrackBarDirection(int currentNumber,int nextNumber)
        {
            if (nextNumber>currentNumber)
                trbViewprocess.Value++;
            else
                trbViewprocess.Value--;
        }

        private void trackbartimer_Tick(object sender, EventArgs e)
        {
            tbCurrentlyProcessed.Text = processlist[0].ToString();
            TrackBarDirection(trbViewprocess.Value, Convert.ToInt32(tbCurrentlyProcessed.Text));
            

            if (rbFirstInFirstOut.Checked)
            {
                
                if (lbToBeProcessed.Items[0].ToString() == processlist[0].ToString())
                    lbToBeProcessed.Items.RemoveAt(0);
                for (int i = 0; i < labels.Count; i++)
                    if (labels[i].Text == processlist[0].ToString())
                    {
                        
                        labels[i].Font = new Font("Arial", 12, FontStyle.Bold);
                        labels[i].ForeColor = Color.Red;
                    }
                if (trbViewprocess.Value == Convert.ToInt32(tbCurrentlyProcessed.Text))
                {
                    processlist = lfi.Process();
                    for (int i = 0; i < labels.Count; i++)
                        if (labels[i].Text == trbViewprocess.Value.ToString())
                        {
                            this.Controls.Remove(labels[i]);
                        }
                    CreateLabel(processlist[processlist.Count - 1]);
                    lbToBeProcessed.Items.Add(processlist[processlist.Count - 1]);
                    //this.FillInLabels();
                }
            }

        }

        private void rbFirstInFirstOut_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
