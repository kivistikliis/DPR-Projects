using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6IteratorPattern
{
    public class EI4S2Iterator:Iterator
    {
        Student[] students;
        int position=0;

        public EI4S2Iterator(Student[] students)
        {
            this.students = students;
        }

        public Student next()
        {
            Student student = students[position];
            position = position + 1;
            return student;
        }

        public Boolean hasNext()
        {
            if (position >= students.Length || students[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
