using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class University : Institute
    {  //properties
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] ScheduleCourse { get; set; }

        //ctors

        public University()
        {

        }
        public University(Guid id) : base(id)
        {
            ID = id;
        }
        public University(Guid id, string name) : base(id, name)
        {

        }
        public University(Guid id, string name, int yearsInService) : base(id, name, yearsInService)
        {

        }
        public University(Guid id, string name, int yearsInService, Student[] students) : base(id, name, yearsInService)
        {
            Students = Students;
        }
        public University(Guid id, string name, int yearsInService, Student[] students, Course[] courses) : base(id, name, yearsInService)
        {
            Students = Students;
            Courses = courses;
        }

        public University(Guid id, string name, int yearsInService, Student[] students, Course[] courses, Grade[] grades) : base(id, name, yearsInService)
        {
            Students = Students;
            Courses = courses;
            Grades = grades;
        }
        public University(Guid id, string name, int yearsInService, Student[] students, Course[] courses, Grade[] grades, Schedule[] scheduleCourse)
            : base(id, name, yearsInService)
        {
            Students = Students;
            Courses = courses;
            Grades = grades;
            ScheduleCourse = scheduleCourse;
        }
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

