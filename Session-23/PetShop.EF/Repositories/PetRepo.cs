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
    public class PetRepo : EntityInterface<Pet>
    {
        public void Add(Pet entity)
        {
            using var context = new PetShopDbContext();
            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            context.Pets.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();

            var dbPet =context.Pets.Where(pet => pet.Id == id).SingleOrDefault();
            if (dbPet is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
           context.Remove(dbPet);
           context.SaveChanges();

        }

        public IList<Pet> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Pets.ToList();
            
        }

        public Pet? GetById(int id)
        {
            using var context = new PetShopDbContext();
            var dbPet = context.Pets.Where(pet => pet.Id == id).SingleOrDefault();

            if (dbPet is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            else
            {
                return dbPet;
            }

        }

        public void Update(int id, Pet entity)
        {
            using var context = new PetShopDbContext();

            var dbPet = context.Pets.Where(pet => pet.Id == id).SingleOrDefault();
            if (dbPet is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbPet.PetStatus = entity.PetStatus;
            dbPet.AnimalType = entity.AnimalType;
            dbPet.Price = entity.Price;
            dbPet.Cost = entity.Cost;
            dbPet.Breed = entity.Breed;
            context.SaveChanges();
        }
    }
}
