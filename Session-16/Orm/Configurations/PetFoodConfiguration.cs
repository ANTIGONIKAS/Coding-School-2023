using Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configurations
{
    public class PetFoodConfiguration : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
         builder.ToTable("PetFood");

            builder.HasKey(petfood => petfood.PetFoodID);
           
            builder.Property(petfood => petfood.PetFoodPrice).HasPrecision(10,2);
            builder.Property(petfood => petfood.PetFoodCost).HasPrecision(10, 2);
          
        
           
       



        }
    }
}
