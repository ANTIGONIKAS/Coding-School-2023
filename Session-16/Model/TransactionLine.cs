using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TransactionLine
    {
        public TransactionLine() { 

        TransactionLineID=Guid.NewGuid();
       

        }
        public Guid TransactionLineID {get; set;} //primarykey

              //Relations
        public Transaction Transaction { get; set; } = null!;   
        public Guid TransactionID { get; set;} //foreignkey
        public Pet Pet { get; set; } = null!;
        public Guid PetID { get; set; } //FK

        public PetFood PetFood { get; set; } = null!; //foreignkey
        public Guid PetFoodID { get; set; }

        public int PetFoodQty { get; set; }
        public Guid SpecialOfferID { get; set; } 
        public decimal PetFoodPrice { get; set; }   
        public decimal PetFoodCost { get; set; }
        public decimal PriceDiscount { get; set; }
        public decimal LineTotal { get; set; }

       

      
        //LineTotal=PetPrice-PetFoodPrice
        //PetFoodPrice=PetFoodQty *PetFoodCost



    }
}
