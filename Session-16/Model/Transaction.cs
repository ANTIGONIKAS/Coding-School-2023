﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Model
{
    public class Transaction {
        public Guid TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid PetID { get; set; }
        public decimal PetPrice { get; set; }
        public Guid PetFoodID { get; set; }
        public int PetFoodQty { get; set; }
        public double PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public Pet Pet { get; set; } = null!;
        public PetFood PetFood { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
        public Employee Employee { get; set; } = null!;

        public Transaction() {
            TransactionID = Guid.NewGuid();
        }
       
    }

}
