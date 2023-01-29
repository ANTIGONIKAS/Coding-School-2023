using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLib
{
    public class Professor : Person
    {
        public string? Rank { get; set; }
        public Course[]? Courses { get; set; }

        //constructors
        public Professor()
        {

        }

        //methods

        public void Teach(Course course, DateTime datetime)
        {

        }

        public void SetGrade(Guid studentID, Guid courseID, int grade)
        {

        }

        //GetName() new method
        


    }
}
    

