using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace PetShop.Model
{
    public class Customer:EntityBase
    {
        public Customer(string title)
        {
            Title = title;

            Detail = new CustomerDetail();
            Transactions= new List<Transaction>();
        }

       public string Title { get; set; }
        public bool Finished { get; set; }

        // Relations
       
        //relations
        public CustomerDetail Detail{ get; set; }
    
   public ICollection<Transaction> Transactions { get; set; }

}
}