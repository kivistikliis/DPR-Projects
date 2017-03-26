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

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            ei4s1Class = new EI4S1();
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ei4s1Iterator = ei4s1Class.createIterator();
            listBox1.Items.Add("EI4S1: ");
            displayStudents(ei4s1Iterator);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ei4s2Iterator = ei4s2Class.createIterator();
            listBox1.Items.Add("EI4S2: ");
            displayStudents(ei4s2Iterator);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            ei4s2Class = new EI4S2();
        }

        private void displayStudents(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                Student student = (Student)iterator.next();
                listBox1.Items.Add(student.getFirstName() + " " + 
                    student.getLastName() + ", age: " + student.getAge() +
                    ", year: " + student.getYear());
            }
        }
    }
}
