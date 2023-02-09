using PetShop.Model.Enums;

namespace PetShop.Model
{
    public class Pet:EntityBase
    {
        public Pet(string title)
        {
            Title=title;
            Detail = new PetDetail();
            Transactions = new List<Transaction>();
        }

       public string Title { get; set; }
        public bool Finished { get; set; }
            
       

        // Relations
        public ICollection<Transaction> Transactions { get; set; }

        public PetDetail Detail { get; set; }
    }


//    For each pet sold the Pet Shop includes one unit of pet food for
//free! The free food must be of the same animal type.The customer
//can buy more pet food.
}
