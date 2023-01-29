using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLib
{
    public class Student : Person
    {
        //properties
        public int RegistrationNumber { get; set; }
        public Course[]? Courses { get; set; }
        public bool Undergraduate { get; set; }
        //constructors
        public Student()
        {
            ID = Guid.NewGuid();
        }



        //methods

        public void Attend(Course course, DateTime datetime)
        {

        }

        public void WriteExam(Course course, DateTime datetime)
        {

        }
    }
}
    

