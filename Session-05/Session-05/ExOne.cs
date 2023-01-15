using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_05
{
    public class ExOne
    {    
        // 1 tropos
        public string ReverseName(string name)
        {
            
            char[] sArray = name.ToCharArray(); 
            Array.Reverse(sArray);
            string rString = new string(sArray);
            return rString;
        }
        // 2 tropos
        public string ReverseNameFor(string name)
        {

            string rString = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                rString += name[i];
            }
            return rString;

        }
      
        //3 tropos
        public static void ReverseString()
        {
            string str = "Antigoni";
            var chars = str.ToCharArray();
            var length = chars.Length;

            for (var i = length - 1; i >= 0; i--)
            {
                Console.Write(chars[i]);
            }
        }











    }
}