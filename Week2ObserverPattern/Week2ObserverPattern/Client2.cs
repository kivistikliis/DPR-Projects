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
    public partial class Client2 : Form, IObserver
    {
        Stock myStock;
        private double newvalue;

        public Client2(Stock myStock)
        {
            InitializeComponent();

            this.myStock = myStock;
            newvalue = myStock.GetValue();
            tbCurrentValue.Text = newvalue.ToString();

        }
        public void Update(double newvalue)
        {
            this.newvalue=newvalue;
            tbCurrentValue.Text = newvalue.ToString();
            if (newvalue % 2 == 0)
                evenood.Text = "This number is even!";
            else
                evenood.Text = "This number is odd!";    
        }

        private void btDeatach_Click(object sender, EventArgs e)
        {
            myStock.Detach(this);
            lbStatus.Text = "Not attached";
        }

        private void btAttach_Click(object sender, EventArgs e)
        {
            myStock.Attach(this);
            lbStatus.Text = "Attached";
        }
    }
}
