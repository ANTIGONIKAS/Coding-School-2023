using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{
  
        public class University : Institute
        {   //properties
            public List<Student> students = new List<Student>();
            public List<Course> courses = new List<Course>();
            public List<Grade> grades = new List<Grade>();
            //public List<Schedule> scheduledCourses = new List<Schedule>();

        public University()
        {
        }

        

       
        public University(Guid id, string name, int yearsInService, Student[] student, Course[] courses, Grade[] grades)
        : base(id, name, yearsInService)
        {
           
        }



        //methods
        public void GetStudents()
        {

        }
        public void GetCourses()
        {

        }
        public void GetGrades()
        {

        }
        public void SetSchedule(Guid courseID, Guid ProfessorID, DateTime datetime)
        {

        }
    }
}

