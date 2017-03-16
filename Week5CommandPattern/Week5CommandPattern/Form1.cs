using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5CommandPattern
{
    public partial class Form1 : Form
    {
        private WashingMachine wm;
        private WashingMachineOn wmon;
        private WashingMachineOff wmoff;
        private RemoteControl myRemote;
        public Form1()
        {
            InitializeComponent();
            wm = new WashingMachine();
            wmon = new WashingMachineOn(wm);
            wmoff = new WashingMachineOff(wm);

            myRemote = new RemoteControl();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myRemote.setCommand(wmon);
            listBox1.Items.Add(myRemote.buttonPressed()); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myRemote.setCommand(wmoff);
            listBox1.Items.Add(myRemote.buttonPressed());
        }
    }
}
