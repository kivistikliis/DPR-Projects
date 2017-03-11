using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week4FactoryPattern
{
    public partial class Form1 : Form
    {
        private String status;
        public Form1()
        {
            InitializeComponent();
                        
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IFactory minionFactory=new MinionFactory();
            GenericGame theGame=new GenericGame(minionFactory);

            status=theGame.run();
            lb_events.Items.Add(status.ToString());
        }
    }
}
