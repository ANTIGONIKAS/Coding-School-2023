using PetShop.Model.Enums;

namespace PetShop.Model
{
    public class PetFood:EntityBase
    {
        public PetFood(string title)
        {
           
            Title=title;
            Transactions = new List<Transaction>();
            Detail=new PetFoodDetail();
        }

      public String Title { get; set; }
      public bool Finished { get; set; }
       

        // Relations
        public ICollection<Transaction> Transactions { get; set; }
        public PetFoodDetail Detail { get; set; }
    }
}
