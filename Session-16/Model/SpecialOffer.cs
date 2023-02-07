using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class SpecialOffer:IEntityBase
    {

        public SpecialOffer() {
              SpecialOfferID=Guid.NewGuid();
        }
        public Guid SpecialOfferID { get; set; }

        //relations
        public PetFood PetFood { get; set; } = null!;
        public Guid PetFoodID { get; set; }
        public double PetFoodPrice { get; set; }

        public TransactionLine TransactionLine { get; set; } = null!;

        public Guid TransactionLineID { get; set; }

        public SpecialOffer(Guid petFoodID)
        {
           

            PetFoodID = petFoodID;

            PetFoodPrice=0;




        }




    }
}
