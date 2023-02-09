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
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        IEnumerable<Employee> IEntityRepo<Employee>.GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Employees.Include(employee => employee.Detail).ToList();

        }
       public Employee? GetById(int id)
        {
             using var context = new PetShopDbContext();

             return context.Employees.Include(employee=>employee.Detail).
             Include(customer => customer.Transactions).SingleOrDefault(employee => employee.Id == id);
       
                }

        public IEnumerable<Employee> GetFinished()
        {
            using var context = new PetShopDbContext();

            return context.Employees.Where(todo => todo.Finished).
                Include(todo => todo.Detail).ToList();
        }

        public void Add(Employee entity)
        {
            using var context = new PetShopDbContext();
            if (entity.Id != 0)
             throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            context.Add(entity);
            context.SaveChanges();
        }
        public void Update(int id, Employee entity)
        {
            using var context = new PetShopDbContext();
            var dbEmployee = context.Employees.Include(employee => employee.Detail).
                SingleOrDefault(employee=>employee.Id==id);
            if (dbEmployee is null)
             throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            dbEmployee.Title = entity.Title;
            dbEmployee.Finished = entity.Finished;
            context.SaveChanges();
        }
            public void Delete(int id)
        {
            using var context = new PetShopDbContext();

            var dbEmployee =context.Employees.
                SingleOrDefault(employee => employee.Id == id);
            if (dbEmployee is null)
           throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            context.Remove(dbEmployee);
            context.SaveChanges();
        }


      

        
          
       
    }
}
