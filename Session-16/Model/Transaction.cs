using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Model;

    public class Transaction { 

     public Transaction()
       {
        TransactionID = Guid.NewGuid();

        //inialize list
        TransactionLines = new List<TransactionLine>();
        

      }
        //PROPERTIES
    
        public Guid TransactionID { get; set; } //PK
    
        public DateTime TransactionDate { get; set; }

        public Customer Customer { get; set; } = null!;
        public Guid CustomerID { get; set; }  //FK
        public Employee Employee { get; set; } = null!; 
        public Guid EmployeeID { get; set; }   //FK
        public Pet Pet { get; set; } = null!;
        public Guid PetID { get; set; } //FK

        public PetFood PetFood { get; set; } = null!; //foreignkey
        public Guid PetFoodID { get; set; }
        public decimal PetPrice { get; set; }
        public decimal TotalPrice { get; set; }
       
             //Relations
        public List<TransactionLine> TransactionLines { get; set; }
        
        
     

      
        //METHODS
       
       //TotalPrice=LineTotal*TrasactionLine.Count 
    }


