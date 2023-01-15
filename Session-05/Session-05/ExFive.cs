using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    //Write a C# program to sort the given array of integers from the lowest to the highest number.

    // Array: [ 0, -2, 1, 20, -31, 50 , -4, 17, 89, 100 ] 
    public class ExFive
    {
        public void sort(int[] numbers)
        {
            Array.Sort(numbers, 0, numbers.Length); 
        }
    }
}
