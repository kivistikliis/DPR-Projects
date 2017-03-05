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

            DisableCheckBoxes();
           
            lbInfo.HorizontalScrollbar = true; 
            lbInfo.ScrollAlwaysVisible = true;

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {

            lbInfo.Items.Add(current);
            lbPrice.Items.Add(current.costs());

            comboBox1.SelectedItem = null;
            current = null;

            DisableCheckBoxes();

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
            EnableCheckBoxes();
            current = (IBeverage)comboBox1.SelectedItem;
        }

        private void EnableCheckBoxes()
        {
            cbCaramel.Enabled = true;
            cbMilk.Enabled = true;
            cbSoy.Enabled = true;
            btSubmit.Enabled = true;
        }

        private void DisableCheckBoxes()
        {
            cbCaramel.Checked = false;
            cbMilk.Checked = false;
            cbSoy.Checked = false;
            cbCaramel.Enabled = false;
            cbMilk.Enabled = false;
            cbSoy.Enabled = false;
            btSubmit.Enabled = false;
        }
    }
}
