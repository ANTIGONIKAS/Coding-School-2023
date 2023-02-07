using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TransactionLine:IEntityBase
    {
        public TransactionLine() {

        TransactionLineID=Guid.NewGuid();
            //Pets= new List<Pet>();
            //PetFoods= new List<PetFood>();
            
        }
        //properties
        public Guid TransactionLineID { get; set;} //primarykey

        //Relations

        public Transaction Transastion { get; set; } = null!;
        public Guid TransactionID { get; set;} //foreignkey

        public PetFood PetFood { get; set; } = null!;
        public Guid PetFoodID { get; set; }

        public Pet Pet { get; set; } =null!;

        public Guid PetID { get; set; }
        public SpecialOffer SpecialOffer { get; set; } = null!;

        public Guid SpecialOfferID { get; set; }





        public int PetFoodQty { get; set;}

        public double PetFoodPrice { get; set;}
        public double PetFoodCost { get; set;}
        public double PetPrice { get; set;}

        public double PriceDiscount { get; set;}
        public double LineTotal { get; set;}





    }
}
