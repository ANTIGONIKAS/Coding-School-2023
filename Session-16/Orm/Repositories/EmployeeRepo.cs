using Model;
using Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee entity)
        {
            using var context = new PetShopContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Delete(Guid id)
        {

            using var context = new PetShopContext();
            var dbEmployee = context.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            context.Remove(dbEmployee);
            context.SaveChanges();
        }

        public void GetAll(Guid id)
        {
            
        }
        public IList<Employee> GetAll()
        {
            using var context = new PetShopContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(Guid id)
        {
            using var context = new PetShopContext();
            return context.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();

        }

        public void Update(Guid id, Employee entity)
        {
            using var context = new PetShopContext();
            var dbEmployee = context.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            dbEmployee.EmployeeName = entity.EmployeeName;
            dbEmployee.EmployeeSurname = entity.EmployeeSurname;
            dbEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            dbEmployee.EmployeeType = entity.EmployeeType;

            context.Remove(dbEmployee);
            context.SaveChanges();
        }
    }
}
