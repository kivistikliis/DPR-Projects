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
        Observer first;
        Observer second;
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            theStock = new Stock();


            first = new Observer(theStock);
            label2.Text = theStock.value.ToString();

            second = new Observer(theStock);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2= new Form2(first);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            theStock.Notify();
            
        }
    }
}
