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
    public partial class Form2 : Form
    {
        Observer first;
        public Form2(Observer first)
        {
            InitializeComponent();
            this.first = first;
            label1.Text = first.newvalue.ToString();
        }
        public void updatelabel()
        {
            label1.Text = first.newvalue.ToString();
        }
    }
}
