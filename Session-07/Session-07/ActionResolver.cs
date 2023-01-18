using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public enum ActionEnum
    {

        Convert,
        Uppercase,
        Reverse,
    }

    public class Message
    {

        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }

        //Change from Message to Text
        public string Text { get; set; }
    }
    public class MessageLogger
    {

        public Message[] Messages { get; set; }
        public MessageLogger()
        {


        }
        public void ReadAll()
        {
        }
        public void Clear()
        {

        }
        public void Write(Message message)
        {

        }

        public class ActionRequest
        {

            public Guid RequestID { get; set; }
            public String Input { get; set; }
            public ActionEnum Action { get; set; }


            public ActionRequest()
            {

            }
            public class ActionResponse
            {

                public Guid RequestID { get; set; }
                public Guid ResponseID { get; set; }
                public String Output { get; set; }
                public ActionResponse()
                {


                }
            }
            public class ActionResolver
            {

                public MessageLogger Logger { get; set; }


                public ActionResolver()
                {

                }

                public ActionResponse Execute(ActionRequest request)
                {
                    string output = string.Empty;
                    try {

                        switch (request.Action)
                        {
                            case ActionEnum.Convert:
                                output=Convert(request.Input);
                                break;
                            case ActionEnum.Uppercase:
                               output= Uppercase(request.Input);
                                break;
                            case ActionEnum.Reverse:
                                output=Reverse(request.Input);
                                break;
                            default:
                                //Error message here
                                break;
                        }

                    }
                    catch(Exception ex)
                    {
                        throw;
                    } 

                    return null;

                }

                public string Convert(string input) {
                    return string.Empty;
                }
                     
                public string Uppercase(string input) {
                    return string.Empty;
                }

                public String Reverse(string input) {
                    return string.Empty;
                     }

            }
        }

    }
}

