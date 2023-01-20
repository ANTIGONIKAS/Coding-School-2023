using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{
    
        public class Grade
        {
            //public Guid ID { get; set }
            public Guid StudentID { get; set; }
            public Guid CourseID { get; set; }
            public int GradeVal { get; set; }

            public Grade()
            {
            }
            public Grade(Guid id, Guid studentID, Guid courseID, int gradeVal)
            {
                // ID = id;
                studentID = studentID;
                CourseID = courseID;
                GradeVal = gradeVal;

            }

        }

    }

