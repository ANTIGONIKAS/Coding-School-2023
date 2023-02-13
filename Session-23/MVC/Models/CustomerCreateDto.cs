using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
 
        public class CustomerCreateDto
        {
           
            [MaxLength(50, ErrorMessage = "limit 50 characters")]
            public string Name { get; set; } = null!;
            
            [MaxLength(100,ErrorMessage ="limit 100 characters")]
            public string Surname { get; set; } = null!;
           
            [MaxLength(50, ErrorMessage = "limit 50 characters")]
            public string Phone { get; set; } = null!;
           
            [MaxLength(50, ErrorMessage = "limit 50 characters")]
            public string Tin { get; set; } = null!;
        }
    

}