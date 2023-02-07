using Model;
using Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Repositories
{
    public  class PetRepo : IEntityRepo<Pet>
    {
        public void Add(Pet entity)
        {

            using var context = new PetShopContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Delete(Guid id)
        {
            using var context = new PetShopContext();
            var dbPet = context.Pets.Where(pet => pet.PetID== id).SingleOrDefault();
            if (dbPet is null)
                return;
            context.Remove(dbPet);
            context.SaveChanges();

        }
        public IList<Pet> GetAll()
        {
            using var context = new PetShopContext();
            return context.Pets.ToList();
        }

        public void GetAll(Guid id)
        {
         
        }

        public Pet? GetById(Guid id)
        {
            using var context = new PetShopContext();
            return context.Pets.Where(pet => pet.PetID == id).SingleOrDefault();
        }

        public void Update(Guid id, Pet entity)
        {
            using var context = new PetShopContext();
            var dbPet = context.Pets.Where(pet => pet.PetID == id).SingleOrDefault();
            if (dbPet is null)
                return ;
            dbPet.Breed = entity.Breed;
            dbPet.Price=entity.Price;
            dbPet.PetStatus= entity.PetStatus;
            dbPet.PetType = entity.PetType;
            dbPet.Cost = entity.Cost;

            context.Remove(dbPet);
            context.SaveChanges();
        }
    }
    }
}
