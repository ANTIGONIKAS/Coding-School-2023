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
        string Input = "Antigoni";
        ActionRequest request = new ActionRequest();
        ActionResolver resolver = new ActionResolver();
        ActionResponse response = new ActionResponse();
        response = resolver.Execute(request);
        resolver.Logger.ReadAll();

        Console.ReadLine();
        Console.WriteLine("the input is:" + Input + "the reverse input is:" + resolver.Reverse(request.Input));
        Console.ReadLine();

      
        
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