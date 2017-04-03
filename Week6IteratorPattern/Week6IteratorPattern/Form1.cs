using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6IteratorPattern
{
    public partial class Form1 : Form
    {
        Class ei4s1Class, ei4s2Class;
        Iterator ei4s1Iterator, ei4s2Iterator;

        public Form1()
        {
            InitializeComponent();    
        }
        private void btn_createEI4S1_Click(object sender, EventArgs e)
        {
            btn_displayEI4S1.Enabled = true;
            ei4s1Class = new EI4S1();
        }

        private void btn_displayEI4S1_Click(object sender, EventArgs e)
        {
            ei4s1Iterator = ei4s1Class.createIterator();
            lb_students.Items.Add("EI4S1: ");
            displayStudents(ei4s1Iterator);
        }

        private void btn_displayEI4S2_Click(object sender, EventArgs e)
        {
            ei4s2Iterator = ei4s2Class.createIterator();
            lb_students.Items.Add("EI4S2: ");
            displayStudents(ei4s2Iterator);
        }

        private void btn_createEI4S2_Click(object sender, EventArgs e)
        {
            btn_displayEI4S2.Enabled = true;
            ei4s2Class = new EI4S2();
        }

        private void displayStudents(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                Student student = (Student)iterator.next();
                lb_students.Items.Add(student.getFirstName() + " " + 
                    student.getLastName() + ", age: " + student.getAge() +
                    ", year: " + student.getYear());
            }
        }
    }
}
