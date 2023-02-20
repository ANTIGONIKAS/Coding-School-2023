using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class Employee
    {

        public Employee(string name,string surname,DateTime hireDateStart,DateTime? hireDateEnd,decimal salaryPerMonth,EmployeeType employeeType)
        {
            
            Name= name;
            Surname= surname;
            HireDateStart= hireDateStart;
            HireDateEnd= hireDateEnd;
            SalaryPerMonth= salaryPerMonth;
            EmployeeType= employeeType;
            Transactions= new List<Transaction>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; } 
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        //relations
        public List<Transaction> Transactions { get; set; }

    }
}
