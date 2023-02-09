using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class EmployeeDetail:EntityBase
    {

        public String? Name { get; set; }
         public String? Surname { get; set; }
         public Enum? EmployeeType { get; set; }

        public decimal  SalaryPerMonth { get; set; }

        //RELATIONS

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
    }
}
