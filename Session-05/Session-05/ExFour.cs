using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    //Write a C# program to multiply all values from Array1 with all values from Array2
    //and display the results in a new Array.
    // Array1: [2, 4, 9, 12]
    // Array2: [1, 3, 7, 10]

    public class ExFour
    {
     public int[,] multiArray(int[] a, int[] b)
        {
            int[,] res = new int[a.Length,b.Length];
            for(int i =0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    res[i,j] = a[i] * b[j];
                }
            }
            return res;
        }
    }
}
