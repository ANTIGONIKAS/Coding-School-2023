using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07
{
    public enum ActionEnum
    {

        Convert,
        Uppercase,
        Reverse,
    }

   


       public class ActionResolver { 
    

       public MessageLogger Logger { get; set; }
        
        //ctor
      public ActionResolver() { 
                    
       Logger  = new MessageLogger();
        }
                     //methods
        public ActionResponse Execute(ActionRequest request) { 
                    

                        ActionResponse response = new ActionResponse();
                        response.ResponseID = Guid.NewGuid();
                        response.RequestID = request.RequestID;
                       

                        Log("EXECUTION START");

                        //Message message= new Message("Execution start");
                        //logger.Messages[0] = messages

                        try
                        {

                     switch (request.Action)
                {
                    case ActionEnum.Convert:
                        Log("CONVERT");
                        response.Output = Convert(request.Input);
                        break;
                    case ActionEnum.Uppercase:
                        Log("UPPERCASE");
                        response.Output = Uppercase(request.Input);
                        break;
                    case ActionEnum.Reverse:
                        Log("REVERSE");
                        response.Output = Reverse(request.Input);
                        break;
                    default:
                        //Error message here
                        break;
                        }

                        }
                        catch (Exception ex)
                        {
                        Log(ex.Message);  
                        }
                        finally
                        {
                         Log("EXECUTION END");

                        }

                        return response;

                    }
                      private void Log(string text) { 
                       Message message= new Message(text);
                      Logger.Write(message);
                       }

                    public string Convert(string input)
                    {
                        //“Convert” you must check if the Input is a decimal number and convert it to binary

                        return string.Empty;
                    }

                    public string Uppercase(string input)
                    {
                        // “Uppercase” you must check if the Input is a string and has more than
                        //one words(separated by a space), then find the longest word in the
                        //Input string and convert it to uppercase.

                        return input.ToUpper();
                    }

                    public String Reverse(string input)
                    {
                  // “Reverse” you must check if the Input is a string and reverse it.

                     string rString = string.Empty;
                     for (int i = input.Length - 1; i >= 0; i--)
                        {
                     rString += input[i];
                          }
                      return rString;

                    
                    }

                }
            }

        

    


