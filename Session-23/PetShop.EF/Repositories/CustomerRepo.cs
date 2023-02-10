using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class CustomerRepo : EntityInterface<Customer>
    {
        public void Add(Customer entity)
        {
            using var context = new PetShopDbContext();
            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            context.Customers.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            context.Customers.Remove(dbCustomer);
            context.SaveChanges();

        }

        public IList<Customer> GetAll()
        {
            using var context = new PetShopDbContext();

            return context.Customers.ToList();
        }

        public Customer? GetById(int id)
        {
            using var context = new PetShopDbContext();

            var dbCustomer=context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            else
            {
                return dbCustomer;
            }
        }

   public void Update(int id, Customer entity)
    {
     using var context = new PetShopDbContext();
            var dbCustomer=context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;
            dbCustomer.Phone = entity.Phone;
            dbCustomer.Tin= entity.Tin;
            context.SaveChanges();
        }             
        }

    }