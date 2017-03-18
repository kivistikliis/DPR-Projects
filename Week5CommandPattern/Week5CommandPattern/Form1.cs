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
        private Radio radio;


        private WashingMachineOn wmon;
        private WashingMachineOff wmoff;

        private RadioOnWithCD radiocd;
        private RadioVolumeUp radioup;
        private RadioVolumeDown radiodown;
        private RadioOff radioff;

        private MacroAllOnCommand allon;
        private MacroAllOffCommand alloff;

        

        private RemoteControl myRemote;
        public Form1()
        {
            InitializeComponent();
            wm = new WashingMachine();
            radio = new Radio();

            wmon = new WashingMachineOn(wm);
            wmoff = new WashingMachineOff(wm);

            radiocd = new RadioOnWithCD(radio);
            radioup = new RadioVolumeUp(radio);
            radiodown = new RadioVolumeDown(radio);
            radioff = new RadioOff(radio);
            
            allon =new MacroAllOnCommand(new Command[2] { wmon, radiocd });
            alloff = new MacroAllOffCommand(new Command[2] { wmoff, radioff });

            myRemote = new RemoteControl();


            myRemote.setCommand(0, wmon, wmoff);
            myRemote.setCommand(1, radiocd, radioff);
            myRemote.setCommand(2, radioup, radiodown);
            myRemote.setCommand(3, allon, alloff);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(myRemote.onButtonWasPushed(0)); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(myRemote.offButtonWasPushed(0));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(myRemote.onButtonWasPushed(1));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(myRemote.offButtonWasPushed(1));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(myRemote.onButtonWasPushed(2));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(myRemote.offButtonWasPushed(2));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(myRemote.undoButtonWasPushed());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(myRemote.onButtonWasPushed(3));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(myRemote.offButtonWasPushed(3));
        }
    }
}
