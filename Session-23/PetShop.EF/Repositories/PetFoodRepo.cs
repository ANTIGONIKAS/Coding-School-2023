using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class PetFoodRepo : EntityInterface<PetFood>
    {
        public void Add(PetFood entity)
        {
            using var context = new PetShopDbContext();

            if (entity.Id != 0)
            {
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            }
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();

            var dbPetFood =context.PetFoods.Where(petFood =>petFood.Id == id).SingleOrDefault();
            if (dbPetFood is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Remove(dbPetFood);
            context.SaveChanges();
        }

        public IList<PetFood> GetAll()
        {
            using var context = new PetShopDbContext();

            return context.PetFoods.ToList();
        }

        public PetFood? GetById(int id)
        {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.Where(petFood => petFood.Id == id).SingleOrDefault();
            if (dbPetFood is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            else
            {
                return dbPetFood;
            }

            }

        public void Update(int id, PetFood entity)
        {
            using var context = new PetShopDbContext();

            var dbPetFood = context.PetFoods.Where(petFood => petFood.Id == id).SingleOrDefault();
            if (dbPetFood is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbPetFood.Price = entity.Price;
            dbPetFood.AnimalType = entity.AnimalType;
            dbPetFood.Cost = entity.Cost;
            context.SaveChanges();
        }
    }
}
