using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6IteratorPattern
{
    public class Student
    {
        string firstName;
        string lastName;
        int age;
        Year year;

        public Student(string firstName, string lastName, int age, Year year)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.year = year;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public int getAge()
        {
            return age;
        }
        public string getYear()
        {
            return (int)year + " year";
        }
    }
}
