using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public interface ITransactionRepo
    {
        IEnumerable<Transaction>GetAllForT(int id);
        IEnumerable<Transaction> GetAllForCuctomer(int customerId);
        IEnumerable<Transaction> GetAllForEmployee(int EmployeeId);
        IEnumerable<Transaction> GetAllForPet(int PetId);
        IEnumerable<Transaction> GetAllForPetFood(int PetFoodId);
 
    }
}
