using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Model
{
    public class Employee :IEntityBase
    {
        public Employee() { 
        
          EmployeeID = Guid.NewGuid();
         
            }  
               


        public enum EmployeeTypeEnum
        {
            Manager,
            Staff
        }
        public Guid EmployeeID { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string EmployeeSurname { get; set; } = null!;
        public double SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }

        //relations
        public Transaction Transaction { get; set; } = null!;
     public Guid TransactionID { get; set; }
   
        

        

       



      


    }

}