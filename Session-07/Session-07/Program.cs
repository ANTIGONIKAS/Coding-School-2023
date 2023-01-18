using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_07.MessageLogger;
using static Session_07.MessageLogger.ActionRequest;

namespace Session_07;
public class Program
{
    public static void Main(string[] args)
    {
        ActionRequest request = new ActionRequest();
        ActionResponse response = new ActionResponse();

        ActionResolver resolver = new ActionResolver();

        response = resolver.Execute(request);



    }
}