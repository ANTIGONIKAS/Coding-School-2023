using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLib
{
    public class Grade
    {

        //PROPERTIES
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeVal { get; set; }

        //ctors

        public Grade()
        {
            ID = Guid.NewGuid();
        }
        public Grade(Guid id)
        {
            ID = id;
        }

        public Grade(Guid studentID, Guid courseID)
        {
            ID = Guid.NewGuid();
            StudentID = studentID;
            CourseID = courseID;
        }

        public Grade(Guid id, Guid studentID, Guid courseID, int gradeVal)
        {
            ID = Guid.NewGuid();
            StudentID = studentID;
            CourseID = courseID;
            GradeVal = gradeVal;

        }

    }

}
    

