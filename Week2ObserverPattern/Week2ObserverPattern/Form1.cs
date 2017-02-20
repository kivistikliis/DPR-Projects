using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week2ObserverPattern
{
    public partial class Form1 : Form
    {
        Stock theStock;
        Client1 cl1;
        Client2 cl2;
        public Form1()
        {
            InitializeComponent();
            theStock = new Stock();

           numChangeValue.Value = Convert.ToDecimal(theStock.GetValue());
           tbCurrentValue.Text = theStock.GetValue().ToString();
           lbNrOfObservers.Text = theStock.GetNrOfAttachedObservers().ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void btChangeValue_Click(object sender, EventArgs e)
        {
            theStock.ChangeValue(Convert.ToDouble(numChangeValue.Value));

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbNrOfObservers.Text = theStock.GetNrOfAttachedObservers().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl1 = new Client1(theStock);
            cl1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cl2 = new Client2(theStock);
            cl2.Show();
        }

        
    }
}
