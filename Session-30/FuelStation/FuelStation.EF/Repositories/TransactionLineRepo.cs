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
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine entity)
        {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var dbTransactionLine=context.TransactionLines.
           Where(transactionLine=>transactionLine.Id== id).SingleOrDefault();
            if (dbTransactionLine is null)
                return;
            context.Remove(dbTransactionLine);
            context.SaveChanges();


            
        }

        public IList<TransactionLine> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.TransactionLines
                .Include(transaction=>transaction.Transaction)
                .Include(transaction=>transaction.Item).ToList();

        }

        public TransactionLine? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.TransactionLines.Where(transaction => transaction.Id == id).
            Include(transaction => transaction.Item)
           .Include(transaction => transaction.Transaction).SingleOrDefault();

        }

        public void Update(int id, TransactionLine entity)
        {
            using var context = new FuelStationDbContext();
            var dbTransactionLine =  context.TransactionLines.
                Where(transaction=> transaction.Id == id)
                .SingleOrDefault();
            if (dbTransactionLine == null)
                return;
            dbTransactionLine.NetValue = entity.NetValue;
            dbTransactionLine.DiscountValue = entity.DiscountValue;
            dbTransactionLine.TotalValue = entity.TotalValue;
            dbTransactionLine.Quantity = entity.Quantity;
            dbTransactionLine.DiscountPercent = entity.DiscountPercent;
            dbTransactionLine.ItemPrice = entity.ItemPrice;
            dbTransactionLine.ItemId = entity.ItemId;
            dbTransactionLine.TransactionId = entity.TransactionId;
            context.SaveChanges();

        }
    }
}
