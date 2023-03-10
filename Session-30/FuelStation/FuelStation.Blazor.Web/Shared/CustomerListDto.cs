using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Web.Shared
{
    public class CustomerListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? CardNumber { get; set; }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

    }
}
