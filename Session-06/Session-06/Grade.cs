using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Grade
    {   //properties
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeVal { get; set; }

        //ctors

        public Grade()
        {

        }
        public Grade(Guid id)
        {
            id = ID;

        }
        public Grade(Guid id, Guid studentID)
        {
            id = ID;
            StudentID = studentID;
        }
        public Grade(Guid id, Guid studentID, Guid courseID)
        {
            id = ID;
            StudentID = studentID;
            CourseID = courseID;

        }
        public Grade(Guid id, Guid studentID, Guid courseID, int gradeVal)
        {
            id = ID;
            StudentID = studentID;
            CourseID = courseID;
            GradeVal = gradeVal;
        }
    }
}