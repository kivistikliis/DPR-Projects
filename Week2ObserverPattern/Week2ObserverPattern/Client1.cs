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
    public partial class Client1 : Form, IObserver
    {
        Stock myStock;
        private double newvalue;
        
        public Client1(Stock newStock)
        {
            InitializeComponent();

            this.myStock = newStock;
            newvalue = myStock.GetValue();
            tbCurrentValue.Text = newvalue.ToString();
        }
        public void Update(double newvalue)
        {
            tbCurrentValue.Text = newvalue.ToString();
        }

        private void btAttach_Click(object sender, EventArgs e)
        {
            myStock.Attach(this);
            lbStatus.Text = "Attached";
        }

        private void btDeatach_Click(object sender, EventArgs e)
        {
            myStock.Detach(this);
            lbStatus.Text = "Not Attached";
        }
    }
}
