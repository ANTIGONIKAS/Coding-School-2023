using FuelStation.Model;
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Web.Shared
{
    public class EmployeeEditDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = " Name has max length 20 characterss.")]
        public string? Name { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = " Surname has max length 20 characters.")]
        public string? Surname { get; set; }
        [Required]

        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        [Required]
        [Range(0, 99999.9, ErrorMessage = "Invalid number  [0-99999.9]")]
        public decimal SalaryPerMonth { get; set; }
        [Required]
        public EmployeeType EmployeeType { get; set; }

       

        //relations
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
