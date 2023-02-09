using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Configurations
{
    public class PetFoodDetailConfiguration : IEntityTypeConfiguration<PetFoodDetail>
    {
        public void Configure(EntityTypeBuilder<PetFoodDetail> builder)
        {
            builder.ToTable("PetFood", "PetShop");

            builder.HasKey(petFoodDetail=>petFoodDetail.Id);
            builder.Property(petFoodDetail=>petFoodDetail.Id).ValueGeneratedOnAdd();

          
            builder.Property(petFoodDetail=>petFoodDetail.Cost).IsRequired();
            builder.Property(petFoodDetail=>petFoodDetail.Price).IsRequired();

            //relations
            builder.HasOne(petFoodDetail => petFoodDetail.PetFood).
           WithOne(petFood => petFood.Detail).
          HasForeignKey<PetFoodDetail>(petFoodDetail => petFoodDetail.PetFoodId).IsRequired();



        }
    }
}
