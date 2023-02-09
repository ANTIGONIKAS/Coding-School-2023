using PetShop.Model.Enums;

namespace PetShop.Model
{
    public class Pet:EntityBase
    {
        public Pet(string breed, AnimalType animalType, PetStatus petStatus, decimal price, decimal cost)
        {
            Breed = breed;
            AnimalType = animalType;
            PetStatus = petStatus;
            Price = price;
            Cost = cost;

            Transactions = new List<Transaction>();
        }

       
        public string Breed { get; set; }
        public AnimalType AnimalType { get; set; }
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }


//    For each pet sold the Pet Shop includes one unit of pet food for
//free! The free food must be of the same animal type.The customer
//can buy more pet food.
}
