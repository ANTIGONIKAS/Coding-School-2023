using F.Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Session_16.Model {
    public class Customer  {

        public Customer()
        {
           
            CustomerID = Guid.NewGuid();
        }

        public Guid CustomerID { get; set; }
        public string Name { get; set; } = null!;  //it is not null
        public string Surname { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string TIN { get; set; } = null!;
        public Transaction Transaction { get; set; } = null!;
        public Guid TransactionID { get; set; }


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
