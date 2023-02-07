using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CustomerF: IEntityBase
    {

        public CustomerF()
        {

            CustomerID = Guid.NewGuid();
            

        }

        public Guid CustomerID { get; set; }


        public string CustomerName { get; set; } = null!;  //it is not null
        public string CustomerSurname { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string TIN { get; set; } = null!;

        //Relations
        public Transaction Transaction { get; set; } = null!;
        public Guid TransactionID { get; set; }


    }


}
       

       


       
        
    

