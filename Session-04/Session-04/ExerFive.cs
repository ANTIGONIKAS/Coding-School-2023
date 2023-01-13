using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Session_04
{
    public class ExerFive
    {
        public void Convert(int sec)
        {
            double minutes = sec / 60;
            double hours = minutes / 60;
            double days = hours / 24;
            double years = days / 365;
            Console.WriteLine("sec    : " + sec);
            Console.WriteLine("minutes: " + minutes);
            Console.WriteLine("hours  : " + hours);
            Console.WriteLine("days   : " + days);
            Console.WriteLine("Years  : " + years);
        }
    }
    
    }

