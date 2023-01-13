// See https://aka.ms/new-console-template for more information
using Session_04;

//Console.WriteLine("Hello, World!");
class Program {
    public static void Main(string[] args)
    {
        ExerOne exerOne = new ExerOne();

        ExerTwo exerTwo = new ExerTwo();

        ExerThree exerThree = new ExerThree();

        ExerFour exerFour = new ExerFour();

        ExerFive exer5 = new ExerFive();

        ExerSeven exer7 = new ExerSeven();



        Console.WriteLine("--------- Exer One ---------");
        Console.WriteLine(exerOne.HelloName());

        Console.WriteLine("---------- Exer Two --------");
        Console.WriteLine(exerTwo.CalcSum());
        Console.WriteLine(exerTwo.Devision());

        Console.WriteLine("--------- Exer Three -------");
        exerThree.Solution();

        Console.WriteLine("--------- Exer Four --------");
        Console.WriteLine(exerFour.MethodFour());

        Console.WriteLine("--------- Exer Five --------");
        exer5.Convert(123456789);

        Console.WriteLine("-------- Exer Seven --------");
        Console.WriteLine("Convert 25 Celsius Degree to Kelvin = " +exer7.ConvertCelsiusToKelvin());
        Console.WriteLine("Convert 25 Celsius Degree to Farhenheit = "+exer7.ConvertCelsiusToFahrenheit());
        Console.WriteLine();
    }
}