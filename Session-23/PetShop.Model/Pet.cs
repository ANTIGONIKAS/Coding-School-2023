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

    public class PetCreateDto
    {
        public string Breed { get; set; } = null!;
        public AnimalType AnimalType { get; set; }
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
    }
    public class PetEditDto
    {
        public int Id { get; set; }
        public string Breed { get; set; } = null!;
        public AnimalType AnimalType { get; set; }
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
    }

    public class PetDeleteDto
    {
        public int Id { get; set; }
        public string Breed { get; set; } = null!;
        public AnimalType AnimalType { get; set; }
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }


    }
    }
