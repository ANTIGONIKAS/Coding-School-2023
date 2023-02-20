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
    public class ItemRepo : IEntityRepo<Item>
    {
        public void Add(Item entity)
        {
            using var context = new FuelStationDbContext();
            context.Items.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var dbItem = context.Items
            .Where(item => item.Id == id)
            .Include(item => item.TransactionLines) .SingleOrDefault();
            if (dbItem == null)
                return;
            context.Items.Remove(dbItem);
            context.SaveChanges();
    

        }

        public IList<Item> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Items
           .Include(item => item.TransactionLines).ToList();
                

        }

        public Item? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.Items.Where(item => item.Id== id)
           .Include(item => item.TransactionLines) .SingleOrDefault();
               

        }
        public void Update(int id, Item entity)
        {
            using var context = new FuelStationDbContext();
            var dbItem = context.Items.Where(item => item.Id == id)
             .Include(item => item.TransactionLines).SingleOrDefault(); 
            if(dbItem == null)
                return;
            dbItem.Code = entity.Code;
            dbItem.Description = entity.Description;
            dbItem.Cost = entity.Cost;
            dbItem.Price = entity.Price;
            dbItem.ItemType = entity.ItemType;
            context.SaveChanges();
                
                
        }
    }

}