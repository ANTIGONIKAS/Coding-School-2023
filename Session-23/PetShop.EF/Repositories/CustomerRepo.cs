using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {

        public IEnumerable<Customer> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Customers.Include(customer => customer.Detail).ToList();

        }

        public Customer? GetById(int id)
        {
            using var context = new PetShopDbContext();

            return context.Customers.Include(customer => customer.Detail).
                Include(customer => customer.Transactions).
                SingleOrDefault(customer => customer.Id == id);


        }
        public IEnumerable<Customer> GetFinished()
        {
            using var context = new PetShopDbContext();
            return context.Customers.Where(todo => todo.Finished).Include(todo => todo.Detail).ToList();
        }
        public void Add(Customer entity)
        {
            using var context = new PetShopDbContext();
            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Customers.Add(entity);
            context.SaveChanges();
        }



        public void Update(int id, Customer entity)
        {
            using var context = new PetShopDbContext();

            var dbTodo = context.Customers.Include(todo => todo.Detail).SingleOrDefault(todo => todo.Id == id);
            if (dbTodo is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            dbTodo.Title = entity.Title;
            dbTodo.Finished = entity.Finished;


            context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbCustomer = context.Customers.SingleOrDefault(customer => customer.Id == id);
            if (dbCustomer is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.Remove(dbCustomer);
            context.SaveChanges();
           
        }
    }

    
    }






 

