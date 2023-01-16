// See https://aka.ms/new-console-template for more information
using Session_05;
class Program
{
    public static void Main(string[] args)
    {


        string name = "Antigoni";

        ExOne exOne = new ExOne();
        ExTwo exTwo = new ExTwo();                           
        ExThree exThree = new ExThree(); 
        ExFour exFour = new ExFour();
        ExFive exFive = new ExFive();

        Console.WriteLine("-----------------ExOne-------------------");
        
        Console.WriteLine("Original name = " + name + " Reverse name  = " + exOne.ReverseName(name));
        Console.WriteLine("Original string = " + name + " Reverse name For =" + exOne.ReverseNameFor(name));
        Console.WriteLine("Reverse name= "); ExOne.ReverseString();
        Console.WriteLine("\n");

        Console.WriteLine("----------------ExTwo=------------------");
        Console.Write("Enter the number -->");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter which way to calculate (0 for 1+2+...+n or 1 for 1*2*..*n) --> ");
        int way = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the result is = " + exTwo.SumOrFactorial(n, way));

        Console.WriteLine("----------------ExThree------------------");
        Console.Write("Enter n to display all primes from 0 to n -->");
        n= Convert.ToInt32(Console.ReadLine());
        ExThree.PrimeNumbers(n);

        Console.WriteLine("\n\n----------------ExFour------------------");
        int[] Array1 = new int[] { 2, 4, 9, 12 };
        int[] Array2 = new int[] { 1, 3, 7, 10 };

        foreach (int i in Array1)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine("\n");
        foreach (int i in Array2)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine("\n");

        int[,] multi = exFour.multiArray(Array1, Array2);

        for (int i = 0; i < Array1.Length; i++)
        {
            for (int j = 0; j < Array2.Length; j++)
            {
                Console.Write(multi[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");

        Console.WriteLine("-------------ExFive-----------------");

        int[] Arr = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

        Console.WriteLine(string.Join(", ", Arr));

        Array.Sort(Arr);
       
        Console.WriteLine(string.Join(", ", Arr));

        Console.ReadKey();


    }

    }











