using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{

    public class Student : Person
    {   //properties
     

            //properties
            public int RegistrationNumber { get; set; }
            public List<Course> courses=new List<Course>();

        //constructors
        public Student()
        {
            ID = Guid.NewGuid();
        }

      

           

            public Student(Guid id, string name, int age) : base(id, name, age)
            {

            }

            public Student(Guid id, string name, int age, int registrationNumber) : base(id, name, age)
            {
                RegistrationNumber = registrationNumber;
            }

            public Student(Guid id, string name, int age, int registrationNumber, Course[] courses) : base(id, name, age)
            {
                RegistrationNumber = registrationNumber;
                
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




