using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ExTwo
    {
        //Write a C# program that asks the user for an integer (n) and gives them 
        //the possibility to choose between computing the sum and computing the product of 1,…,n.
        
        public int SumOrFactorial(int num,int factorial)
        {
            
            if (num <= 0) { 
            
                return 0;
            }
            int res = 1;
            if (factorial == 0){
                for(int i = 2; i <= num; i++) {
                    res += i;
                }
            }
            else
            {
                for (int i = 2; i <= num; i++)
                {
                    res *= i;
                }
            }
            return res;
        }
    }
}
