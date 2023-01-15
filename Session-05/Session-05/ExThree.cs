using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ExThree
    {
        public static void PrimeNumbers(int n)
        {
            if (n == 0)
            {
                return;
            }
            if (n == 1)
            {
                return;
            }
            int divisors; 
            for (int num = 2; num <= n; num++)
            {  
                divisors = 0; 
                for (int i = 2; i <= (num / 2 + 1); i++)
                {
                    if (num % i == 0)
                    {
                        divisors++;
                        break;
                    }
                }
                if (divisors == 0) Console.Write(num + ", ");
            }
        }
    }
}