using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PetShop.Model;

namespace PetShop.EF.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            // Table Name
            builder.ToTable("Pet","PetShop");

            // Primary Key
            builder.HasKey(pet => pet.Id);

            //properties
            builder.Property(pet => pet.Id).ValueGeneratedOnAdd();
            builder.Property(pet => pet.Title).HasMaxLength(maxLength: 200);
         
            builder.HasIndex(pet => pet.Finished);
            
           

      
        }
    }
}
