using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>, ITransactionRepo
    {
        public IEnumerable<Transaction> GetAllForCuctomer(int customerId)
        {
            using var context = new PetShopDbContext();
            return context.Transactions.Include(transaction => transaction.Customer).ToList();

        }
        public IEnumerable<Transaction> GetAllForEmployee(int EmployeeId)
        {
            using var context = new PetShopDbContext();
            return context.Transactions.Include(transaction => transaction.Employee).ToList();
        }

        public IEnumerable<Transaction> GetAllForPet(int PetId)
        {
            using var context = new PetShopDbContext();
            return context.Transactions.Include(transaction => transaction.Pet).ToList();
        }


    public IEnumerable<Transaction> GetAllForPetFood(int PetFoodId)
    {
        using var context = new PetShopDbContext();
        return context.Transactions.Include(transaction => transaction.PetFood).ToList();
    }

       public Transaction? CustomerGetById(int id)
        {
        using var context = new PetShopDbContext();
        return context.Transactions.Include(transaction => transaction.Customer).
            SingleOrDefault(transaction => transaction.Id == id);

    }
        public Transaction? EmployeeGetById(int id)
        {
            using var context = new PetShopDbContext();

            return context.Transactions.Include(transaction => transaction.Employee).
                SingleOrDefault(transaction => transaction.Id == id);

        }
        public Transaction? PetGetById(int id)
        {
            using var context = new PetShopDbContext();

            return context.Transactions.Include(transaction => transaction.Pet).
                SingleOrDefault(transaction => transaction.Id == id);

        }
        public Transaction? PetFoodGetById(int id)
        {
            using var context = new PetShopDbContext();

            return context.Transactions.Include(transaction => transaction.PetFood).
                SingleOrDefault(transaction => transaction.Id == id);

        }
        public void Add(Transaction entity)
        {
            using var context = new PetShopDbContext();

            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Transactions.Add(entity);
            context.SaveChanges();

        }
        public void Update(int id, Transaction entity)
        {
            using var context = new PetShopDbContext();

            var dbTransaction = context.Transactions.SingleOrDefault(transaction => transaction.Id == id);

            if (dbTransaction is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            dbTransaction.Date = entity.Date;
            dbTransaction.PetPrice = entity.PetPrice;
            dbTransaction.PetFoodQty = entity.PetFoodQty;
            dbTransaction.PetFoodPrice = entity.PetFoodPrice;
            dbTransaction.TotalPrice = entity.TotalPrice;
            context.SaveChanges();

        }
        public void Delete(int id)
        {
            using var context = new PetShopDbContext();

            var dbTransaction = context.Transactions.SingleOrDefault(transaction => transaction.Id == id);
            if (dbTransaction is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.Transactions.Remove(dbTransaction);
            context.SaveChanges();

        }


     

        public IEnumerable<Transaction> GetAllForT(int id)
        {
            using var context = new PetShopDbContext();
            return context.Transactions.Where(transaction => transaction.Id == id).ToList();
        }

        public IEnumerable<Transaction> GetAll()
        {
            throw new NotImplementedException();
        }

        public Transaction? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
