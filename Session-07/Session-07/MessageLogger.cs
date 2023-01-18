using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07;
public class Message
{

    public Guid ID { get; set; }
    public DateTime TimeStamp { get; set; }

    //Change from Message to Text
    public string Text { get; set; }
    public Message()
    {

        ID = Guid.NewGuid();
    }
    public Message(string text)
    {
        ID = Guid.NewGuid();
        TimeStamp = DateTime.Now;
        Text = text;

    }
}
  public class MessageLogger
{    //PROPERTIES
    public Message[] Messages { get; set; }
    private int _messageCounter =0;
    // CTOR
    public MessageLogger() { 
    
     Messages = new Message[1000];


    }
    public void ReadAll() { 
    
        foreach (Message message in Messages) { 
        

            if (message != null)
            {
                Console.WriteLine(message.Text);
            }

        }
    }

     public void Clear(){
        Messages = new Message[1000];
        _messageCounter = 0;
    }


    public void Write(Message message)
    {//Message message= new Message("Execution start");
        Messages[_messageCounter] = message;
        _messageCounter++;

        //logger.Messages[0] = message;

    }

}

