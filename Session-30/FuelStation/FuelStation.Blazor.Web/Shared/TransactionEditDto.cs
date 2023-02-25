using FuelStation.Model.Enums;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Web.Shared
{
    public class TransactionEditDto
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }

        public PayMethod PayMethod { get; set; }

        public decimal TotalValue { get; set; }

        //relations
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
