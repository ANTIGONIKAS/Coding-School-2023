using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class Ledger
    {

        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
        public Ledger()
        { 
        }
        public Ledger(DateTime dateTime)
        {
            Year = dateTime.Year;
            Month = dateTime.Month;

        }
    }
}
