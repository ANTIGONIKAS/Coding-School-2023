using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Model
{
    public class PetFood :IEntityBase{

        public PetFood() {

            PetFoodID = Guid.NewGuid();
           
        }



        public Guid PetFoodID { get; set; }
        public AnimalTypeEnum AnimalType { get; set; }

        public double PetFoodPrice { get; set; }
        public double PetFoodCost { get; set; }

        public TransactionLine TransactionLine { get; set; } = null!;
        public Guid TransactionLineID { get; set; }
        public SpecialOffer SpecialOffer { get; set; } = null!;
        public Guid SpecialOfferID { get; set; }




        public enum AnimalTypeEnum
        {
            Bird,
            Cat,
            Dog,
            None
        }

        
    }

}