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
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbTransaction is null)
                return;
            context.Remove(dbTransaction);
            context.SaveChanges();

        }

        public IList<Transaction> GetAll()
        {
            using var context = new FuelStationDbContext();
            return  context.Transactions
               .Include(transaction => transaction.TransactionLines)
               .Include(transaction => transaction.Customer)
               .Include(transaction => transaction.Employee)
               .ToList();

        }

        public Transaction? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return  context.Transactions.Where(transaction => transaction.Id == id)
            .Include(transaction => transaction.TransactionLines)
            .Include(transaction => transaction.Customer)
            .Include(transaction => transaction.Employee).SingleOrDefault();             
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new FuelStationDbContext();
            var dbTransaction = context.Transactions.Where(transaction=> transaction.Id == id).SingleOrDefault();
            if (dbTransaction == null)
                return;
            dbTransaction.Date = entity.Date;
            dbTransaction.PayMethod= entity.PayMethod;
            dbTransaction.TotalValue= entity.TotalValue;
            dbTransaction.EmployeeId = entity.EmployeeId;
            dbTransaction.CustomerId = entity.CustomerId;
            context.SaveChanges();


        }
    }
}
