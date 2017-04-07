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
        Students students;

        public Form1()
        {
            InitializeComponent();
            students = new Students();   
        }
        private void btn_createEI4S1_Click(object sender, EventArgs e)
        {
            btn_displayEI4S1.Enabled = true;
            students.createEI4S1();
            
        }

        private void btn_displayEI4S1_Click(object sender, EventArgs e)
        { 
            lb_students.Items.Add("EI4S1: ");
            displayStudents(students.createEI4S1Iterator());
        }

        private void btn_displayEI4S2_Click(object sender, EventArgs e)
        {
            lb_students.Items.Add("EI4S2: ");
            displayStudents(students.createEI4S2Iterator());
        }

        private void btn_createEI4S2_Click(object sender, EventArgs e)
        {
            btn_displayEI4S2.Enabled = true;
            students.createEI4S2();
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
