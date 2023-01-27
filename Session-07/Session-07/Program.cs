using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_07.MessageLogger;


namespace Session_07;
public class Program
{
    public static void Main(string[] args)
    {
        string Input = "I learn programming ";
        ActionRequest request = new ActionRequest(Input);
        ActionResolver resolver = new ActionResolver();
        ActionResponse response = new ActionResponse();
        
        Console.WriteLine("\nthe input is:" + Input + "\nthe reverse input is:" + resolver.Reverse(request.Input));
        Console.WriteLine("\nthe input is:" + Input + "\nthe reverse input is:" + resolver.Uppercase(request.Input));
        request.Input = "23";
        
        Console.WriteLine("\nthe input is: " + request.Input + "\nthe binary represantion is:" + resolver.Convert(request.Input));
        Console.ReadLine();
         response = resolver.Execute(request);
         resolver.Logger.ReadAll();


      
        
        //display messages from logger
         foreach (Message message in resolver.Logger.Messages)
        {
            if (message != null)
            {
                Console.WriteLine(message.Text);
            }

            Console.ReadLine();
        }
    }
}