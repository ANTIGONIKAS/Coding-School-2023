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
    public class PetDetailConfiguration : IEntityTypeConfiguration<PetDetail>
    {
        public void Configure(EntityTypeBuilder<PetDetail> builder)
        {
            builder.ToTable("PetDetail", "PetShop");

            builder.HasKey(petDetail=>petDetail.Id);
            builder.Property(petDetail=>petDetail.Id).ValueGeneratedOnAdd();
            builder.Property(petDetail=>petDetail.Breed).IsRequired();
            builder.Property(petDetail=>petDetail.Cost).IsRequired();
            builder.Property(petDetail=>petDetail.Price).IsRequired();
            

            builder.HasOne(petDetail=>petDetail.Pet).WithOne(pet=>pet.Detail).
                HasForeignKey<PetDetail>(petDetail=>petDetail.PetId).IsRequired();
        }
    }
}
