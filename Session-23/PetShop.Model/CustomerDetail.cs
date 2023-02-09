using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class CustomerDetail:EntityBase
    {
       
        public string? Name { get; set; }
      
        public string? Surname { get; set; }
     
        public string? Phone { get; set; }
       
        public string? Tin { get; set; }

        //Relations
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
