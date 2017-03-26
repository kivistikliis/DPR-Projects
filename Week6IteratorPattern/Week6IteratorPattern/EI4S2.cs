using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6IteratorPattern
{
    class EI4S2:Class
    {
        const int MAX_Std = 6;
        int numberOfItems = 0;
        Student[] students;

        public EI4S2()
        {
            students = new Student[MAX_Std];
            addStudent("Alexandru", "Prodrom", 20, Year.SECOND);
            addStudent("Liis", "Kivistik", 20, Year.SECOND);
        }

        public Iterator createIterator()
        {
            return new EI4S2Iterator(students);
        }

        public string addStudent(String firstName, String lastName,
        int age, Year year)
        {
            Student student = new Student(firstName, lastName, age, year);
            if (numberOfItems >= MAX_Std)
            {
                return "Exceeding the limit of students for this class!";
            }
            else
            {
                students[numberOfItems] = student;
                numberOfItems = numberOfItems + 1;
                return "Student successfully added to EI3S2!";
            }
        }

        public Student [] getStudents()
        {
            return students;
        }
    }
}
