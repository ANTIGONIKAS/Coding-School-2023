using EF.Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Session_16.Model
{
    public class Employee
    {
        public Employee()
        {
            EmployeeID = Guid.NewGuid();
        }


        public enum EmployeeTypeEnum
        {
            Manager,
            Staff
        }
        public Guid EmployeeID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public double SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }


        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", Name, Surname);
            }
        }



        public Employee(Guid employeeID, String name, String surname, double salaryPerMonth, EmployeeTypeEnum employeeType) 
        {
            EmployeeID = employeeID;
            SalaryPerMonth = salaryPerMonth;
            EmployeeType = employeeType;
        }


    }

}