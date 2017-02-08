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
        IProcessMode mode;
        RequestList rl;
        List<int> processlist;
        List<Label> labels;
        private Label l;
        private TextBox tb;
        public Form1()
        {
            InitializeComponent();
            processlist = new List<int>();
            labels = new List<Label>();
            Random r = new Random();
            processlist.Add(0);

            for (int i = 0; i < 10; i++)
            {
                processlist.Add(r.Next(0, 100));
            }

            foreach (int i in processlist)
            {
                lbToBeProcessed.Items.Add(i);
            }
            
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            int height = trbViewprocess.Height;
            Point loc = trbViewprocess.Location;
            int a = loc.X+50;
            int tickfreq = height / 100;

            foreach (int i in processlist)
            {
                l = new Label();
               int b = (loc.Y + height) - (tickfreq* i) -20;
               
               l.Location = new Point(a,b);
                l.Text = i.ToString();
                l.Font = new Font("Arial", 8);
                l.Padding = new Padding(0, 0, 0, 0);
                labels.Add(l);
                this.Controls.Add(l);

            }
            

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tb = new TextBox();
            Controls.Add(tb);

        }

        private void trbViewprocess_Scroll(object sender, EventArgs e)
        {
            tbCurrentlyProcessed.Text = trbViewprocess.Value.ToString();
        }
    }
}
