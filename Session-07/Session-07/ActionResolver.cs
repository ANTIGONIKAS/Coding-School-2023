using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public enum ActionEnum { 
    
        Convert,
        Uppercase,
        Reverse,
    }

    public class Message { 
    
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }

        //Change from Message to Text
        public string Text { get; set; }
    }
    public class MessageLogger { 
    
        public Message[] Messages { get; set; }
        public MessageLogger() { 
        

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
    public class ActionRequest { 
        
         public Guid RequestID { get; set; }
         public String Input { get; set; }
         public ActionEnum ActionEnum { get; set; }   


         public ActionRequest() { 
            
            }
    public class ActionRespose
            {

         public Guid RequestID { get; set; }
         public Guid ResponseID { get; set; }
         public String Output { get; set; }
         public ActionRespose() { 
                

         }
         }
    public class ActionResolver { 
        
        public MessageLogger Logger { get; set; }


    public ActionResolver() { 
                
                }

    public ActionRespose Execute(Action request) {



           return null;        
           
        }


       }

     }
  }
}
    

