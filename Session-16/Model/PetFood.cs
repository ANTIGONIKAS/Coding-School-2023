using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Model
{
    public class PetFood
    {
        public Guid PetFoodID { get; set; } 
        public AnimalTypeEnum AnimalType { get; set; }

        public decimal PetFoodPrice { get; set; }
        public decimal PetFoodCost { get; set; }
        public TransactionLine TransactionLine { get; set; } = null!;
        public Guid TransactionLineID { get; set; }
        public Guid PetID { get; set; }
         public Pet Pet { get; set; } = null!;

        public enum AnimalTypeEnum
        {
            Bird,
            Cat,
            Dog,
            None
        }

        public PetFood()
        {
            PetFoodID= Guid.NewGuid();
        }
    }
}
