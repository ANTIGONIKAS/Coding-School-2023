using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course();
            c1.ID = 1;  
            c1.Code = 2;
            c1.Subject = "PROGRAMMING";
            Console.WriteLine(c1);
        }
    }
}
