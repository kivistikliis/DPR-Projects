using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6IteratorPattern
{
    class EI4S1Iterator:Iterator 
    {
        List<Student> students;
        int position = 0;

        public EI4S1Iterator(List<Student> students)
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
            if (position >= students.Count)
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
