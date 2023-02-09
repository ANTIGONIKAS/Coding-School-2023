﻿using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class PetRepo : IEntityRepo<Pet>
    {

        IEnumerable<Pet> IEntityRepo<Pet>.GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Pets.Include(pet => pet.Detail).ToList();
        }
        public Pet? GetById(int id)
        {
            using var context = new PetShopDbContext();

            return context.Pets.Include(pet=>pet.Detail).
                Include(pet=>pet.Transactions).SingleOrDefault(pet => pet.Id == id);


        }
        public IEnumerable<Pet> GetFinished()
        {
            using var context = new PetShopDbContext();

            return context.Pets.Where(pet => pet.Finished).
                Include(pet => pet.Detail).ToList();
        }

        public void Add(Pet entity)
        {
            using var context = new PetShopDbContext();
            if (entity.Id != 0)
          throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            context.Add(entity);
            context.SaveChanges();
           
        }

        

        public void Update(int id, Pet entity)
        {
            using var context = new PetShopDbContext();

            var dbPet = context.Pets.Include(pet=>pet.Detail).SingleOrDefault(pet => pet.Id == id);
            if (dbPet is null)
        throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            dbPet.Title = entity.Title;
            dbPet.Finished = entity.Finished;

            //if datetime?
           
            context.SaveChanges();
        }

       public void Delete(int id)
        {
            using var context = new PetShopDbContext();

            var dbPet =context.Pets.SingleOrDefault(pet => pet.Id == id);
            if (dbPet is null)
          throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            context.Remove(dbPet);
            context.SaveChanges();
            
        }
    }
}
