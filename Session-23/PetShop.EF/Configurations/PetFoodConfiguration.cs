using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PetShop.Model;

namespace PetShop.EF.Configurations
{
    public class PetFoodConfiguration : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            // Table Name
            builder.ToTable("PetFood","PetShop");

            // Primary Key
            builder.HasKey(petFood => petFood.Id);

            builder.Property(petFood => petFood.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(petFood => petFood.Title).HasMaxLength(maxLength: 200);
            builder.HasIndex(petFood=> petFood.Finished);
           

           
        }
    }
}
