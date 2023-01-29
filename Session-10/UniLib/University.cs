using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLib
{
    public class University : Institute
    {

        //properties
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule>? ScheduledCourses { get; set; }

        public University(Guid id)
        {
            ID = id;
        }
        public University()
        {

            ID = Guid.NewGuid();
            Students = new List<Student>();
            Courses = new List<Course>();
            Grades = new List<Grade>();
            ScheduledCourses = new List<Schedule>();
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

    

