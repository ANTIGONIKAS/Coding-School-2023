using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Web.Shared
{
    public class CustomerEditDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Name has max length 20 characters")]
        public string? Name { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Surname has max length 20 characters")]
        public string? Surname { get; set; }
        [Required]
        [RegularExpression(@"^A[a-zA-Z-0-9]{1,19}$", ErrorMessage = "Card has to begins with A letter. Max length is 20 characters")]
        public string? CardNumber { get; set; }


        //Relations
        public List<Transaction> Transactions { get; set; }=new List<Transaction>();
    }
}
