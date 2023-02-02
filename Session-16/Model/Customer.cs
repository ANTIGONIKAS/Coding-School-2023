using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Customer  {

        public Customer()
        {
           
            CustomerID = Guid.NewGuid();
        }

        public Guid CustomerID { get; set; }

               //Relations
        public Transaction Transaction { get; set; } = null!;
        public Guid TransactionID { get; set; }   
        
        public string CustomerName { get; set; } = null!;  //it is not null
        public string CustomerSurname { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string TIN { get; set; } = null!;
        


        public string FullName {
            get {
                return String.Format("{0} {1}", CustomerName, CustomerSurname);
            }
        }

      
       

       


       
        
    }
}
