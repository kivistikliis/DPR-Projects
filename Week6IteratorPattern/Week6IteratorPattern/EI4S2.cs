using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6IteratorPattern
{
    public class EI4S2:Class
    {
        private const int MAX_STD = 6;
        private int numberOfItems = 0;
        private Student[] students;

        public EI4S2()
        {
            students = new Student[MAX_STD];
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
            if (numberOfItems >= MAX_STD)
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
