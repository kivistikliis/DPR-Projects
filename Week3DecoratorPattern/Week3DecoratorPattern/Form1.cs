using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week3DecoratorPattern
{
    public partial class Form1 : Form
    {
        IBeverage americano, cappuccino, mochachino;
        IBeverage current;

        public Form1()
        {
            InitializeComponent();

            americano = new Americano();
            cappuccino = new Cappuccino();
            mochachino = new Mochachino();

            comboBox1.Items.Add(americano);
            comboBox1.Items.Add(cappuccino);
            comboBox1.Items.Add(mochachino);

            cbCaramel.Enabled = false;
            cbMilk.Enabled = false;
            cbSoy.Enabled = false;

           
            lbInfo.HorizontalScrollbar = true; 
            lbInfo.ScrollAlwaysVisible = true;

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {

            cbCaramel.Enabled = true;
            cbMilk.Enabled = true;
            cbSoy.Enabled = true;

            lbInfo.Items.Add(current);
            lbPrice.Items.Add(current.costs());

            comboBox1.SelectedItem = null;
            current = null;

            cbCaramel.Checked = false;
            cbMilk.Checked = false;
            cbSoy.Checked = false;
            btSubmit.Enabled = false;
        }

        private void cbCaramel_CheckedChanged(object sender, EventArgs e)
        {
            current = new Caramel(current);
            cbCaramel.Enabled = false;
        }

        private void cbMilk_CheckedChanged(object sender, EventArgs e)
        {
            current = new Milk(current);
            cbMilk.Enabled = false;
        }

        private void cbSoy_CheckedChanged(object sender, EventArgs e)
        {
            current = new Soy(current);
            cbSoy.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCaramel.Enabled = true;
            cbMilk.Enabled = true;
            cbSoy.Enabled = true;
            btSubmit.Enabled = true;
            current = (IBeverage)comboBox1.SelectedItem;
        }
    }
}
