using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Session_16.Model {
    public class Customer  {

        public Customer()
        {
           //id = id;
            CustomerID = Guid.NewGuid();
        }

        public Guid CustomerID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string Phone { get; set; }
        public string?TIN { get; set; }

        public string FullName {
            get {
                return String.Format("{0} {1}", Name, Surname);
            }
        }

        //ctors
        public Customer(Guid customerID, String name,String surname, string phone, string tIN) 
        {
            CustomerID = customerID;
            Phone = phone;
            TIN = tIN;
        }
       

       


       
        
    }
}
