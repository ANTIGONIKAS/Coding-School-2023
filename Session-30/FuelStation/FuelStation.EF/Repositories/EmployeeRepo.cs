using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee entity)
        {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var dbEmployee = context.Employees.Where(employee => employee.Id == id)
            .Include(employee=>employee.Transactions).SingleOrDefault();
            if (dbEmployee is null)
                return;
            context.Remove(dbEmployee);
            context.SaveChanges();

        }

        public IList<Employee> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Employees
            .Include(employee => employee.Transactions)
            .ToList();

        }

        public Employee? GetById(int id)
        {
          using var context = new FuelStationDbContext();
            return context.Employees
            .Where(employee => employee.Id == id)
           .Include(employee => employee.Transactions).SingleOrDefault();

             
        }

        public void Update(int id, Employee entity)
        {
         using var context = new FuelStationDbContext();
         var dbEmployee = context.Employees
        .Where(employee => employee.Id== id)
        .Include(employee=>employee.Transactions).SingleOrDefault();
            if (dbEmployee is null)
                return;
            dbEmployee.Name= entity.Name;
            dbEmployee.Surname= entity.Surname;
            dbEmployee.HireDateStart= entity.HireDateStart;
            dbEmployee.HireDateEnd = entity.HireDateEnd;
            dbEmployee.SalaryPerMonth= entity.SalaryPerMonth;
            dbEmployee.EmployeeType= entity.EmployeeType;
            context.SaveChanges();
        


        }
    }
}
