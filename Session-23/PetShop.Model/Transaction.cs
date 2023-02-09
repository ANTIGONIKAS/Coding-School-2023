using System.ComponentModel.DataAnnotations;

namespace PetShop.Model
{
    public class Transaction: EntityBase
    {
        public Transaction(decimal petPrice, int petFoodQty, decimal petFoodPrice, decimal totalPrice)
        {
            Date = DateTime.Now;
            PetPrice = petPrice;
            PetFoodPrice = petFoodPrice;
            PetFoodQty = petFoodQty;
            TotalPrice = totalPrice;
        }

        [Required]
        public DateTime Date { get; set; }
        [Required]
        public decimal PetPrice { get; set; }
        [Required]
        public int PetFoodQty { get; set; }
        [Required]
        public decimal PetFoodPrice { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        public int PetId { get; set; }
        public Pet Pet { get; set; } = null!;

        public int PetFoodId { get; set; }
        public PetFood PetFood { get; set; } = null!;
    }
}
