using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class Transaction
    {
        public Transaction(DateTime date,PayMethod payMethod,decimal totalValue)
        {
            
            Date = date;
            PayMethod = payMethod;
            TotalValue = totalValue;
          

            TransactionLines= new List<TransactionLine>();

        }
        public int Id {get; set; }
        public DateTime Date { get; set; }

        public PayMethod PayMethod { get; set; }

        public decimal TotalValue { get; set; }

        //relations
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public List<TransactionLine> TransactionLines { get; set; }
    }
}
