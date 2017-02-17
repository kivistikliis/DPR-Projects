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
        Form3 form3;
        //List<Form> forms;
        public Form1()
        {
            InitializeComponent();
            theStock = new Stock();
            //forms = new List<Form>();

            first = new Observer(theStock);
            second = new Observer(theStock);

            numChangeValue.Value = Convert.ToDecimal(theStock.GetValue());
           tbCurrentValue.Text = theStock.GetValue().ToString();
           lbNrOfObservers.Text = theStock.GetNrOfAttachedObservers().ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2= new Form2(first);
            form2.Show();
            //forms.Add(form2);

            form3 = new Form3(second);
            form3.Show();
            //forms.Add(form3);

            timer1.Enabled = true;
        }

        private void NotifyForms()
        {
                theStock.ChangeValue(Convert.ToDouble(numChangeValue.Value));
                form2.UpdateForm();
                form3.UpdateForm();
                //How can we efficiently loop through the list of forms and for each form call our generated method UpdateForm()?
               
                numChangeValue.Value = Convert.ToDecimal(theStock.GetValue());
                tbCurrentValue.Text = theStock.GetValue().ToString();
        }

        private void btChangeValue_Click(object sender, EventArgs e)
        {
            NotifyForms();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbNrOfObservers.Text = theStock.GetNrOfAttachedObservers().ToString();
        }

        
    }
}
