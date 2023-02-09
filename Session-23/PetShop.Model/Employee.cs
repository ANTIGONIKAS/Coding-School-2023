using PetShop.Model.Enums;

namespace PetShop.Model
{
    public class Employee:EntityBase
    {
        public Employee(string title)
        {
            Title = title;

            Transactions = new List<Transaction>();

            Detail= new EmployeeDetail();
        }

       
        public String Title { get; set; }
        public bool Finished { get; set; }

        // Relations
        public EmployeeDetail Detail { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
