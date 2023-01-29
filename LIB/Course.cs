using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLib
{
    public class Course
    {
        //properties
        public Guid ID { get; set; }
        public string? Code { get; set; }  //o code na ginei Guid
        public string? Subject { get; set; }

        public Course()
        {
            ID = Guid.NewGuid();
            // Code = Guid.NewGuid();
        }
        public Course(Guid id, string code, string subject)
        {
            ID = id;
            Code = code;
            Subject = subject;
        }



    }

}
    

