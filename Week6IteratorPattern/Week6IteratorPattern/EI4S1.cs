using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6IteratorPattern
{
    public class EI4S1:Class
    {
        private List<Student> students;

        public EI4S1()
        {
            students = new List<Student>();
            addStudent("Dimitar", "Markov", 20, Year.SECOND);
            addStudent("Dmitrii", "Orlov", 19, Year.SECOND);
        }
        public Iterator createIterator()
        {
            return new EI4S1Iterator(students);
        }

        public string addStudent(String firstName, String lastName,
        int age, Year year)
        {
            Student student = new Student(firstName, lastName, age, year);
            students.Add(student);

            return "Student successfully added to EI3S1!";
        }

        public List<Student> getStudents()
        {
            return students;
        }
    }
}
