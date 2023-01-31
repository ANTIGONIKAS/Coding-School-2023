using EF.Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.Session_16.Model
{
    public class PetFood
    {
        public Guid PetFoodID { get; set; } 
        public AnimalTypeEnum AnimalType { get; set; }

        public double PetFoodPrice { get; set; }
        public double Cost { get; set; }
        public enum AnimalTypeEnum
        {
            Bird,
            Cat,
            Dog,
            None
        }

        //public PetFood(Guid petFoodID,AnimalTypeEnum animalType, double petFoodPrice, double petFoodCost) {
        //    PetFoodID= petFoodID;   
        //    AnimalType= animalType;
        //    PetFoodPrice = petFoodPrice;    
        //    PetFoodCost = petFoodCost;  
        //}
        public PetFood()
        {
            PetFoodID= Guid.NewGuid();
        }
    }
}
