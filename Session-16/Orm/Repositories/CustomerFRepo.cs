using Model;
using Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Repositories
{
    public class CustomerFRepo : IEntityRepo<CustomerF>
    {
       
        public void Add(CustomerF entity)

        {
            using var context = new PetShopContext();
            context.Add(entity);
            context.SaveChanges();
           
        }

        public void Delete(Guid id)
        {
            using var context = new PetShopContext();
            var dbCustomerF=context.Customers.Where(customer=>customer.CustomerID==id).SingleOrDefault();
            if (dbCustomerF is null)
                return;
            context.Remove(dbCustomerF);
            context.SaveChanges();
            
        }

        public IList<CustomerF> GetAll()
        {
            using var context = new PetShopContext();
            return context.Customers.ToList();
        }

        public void GetAll(Guid id)
        {
           
        }

        public CustomerF? GetById(Guid id)
        {
            using var context = new PetShopContext();
            return context.Customers.Where(customer => customer.CustomerID == id).SingleOrDefault();

        }

        public void Update(Guid id, CustomerF entity) { 
        
          using var context = new PetShopContext();
            var dbCustomerF = context.Customers.Where(customer => customer.CustomerID == id).SingleOrDefault();
            if (dbCustomerF is null)
                return;
            dbCustomerF.TIN = entity.TIN;
            dbCustomerF.CustomerName = entity.CustomerName;
            dbCustomerF.CustomerSurname = entity.CustomerSurname;
            dbCustomerF.Phone= entity.Phone;

            context.Remove(dbCustomerF);
            context.SaveChanges();
        }

      
    }
}
