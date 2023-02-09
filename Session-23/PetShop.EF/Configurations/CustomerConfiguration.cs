using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PetShop.Model;

namespace PetShop.EF.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Table Name
            builder.ToTable("Customer","PetShop");

            // Primary Key
            builder.HasKey(customer => customer.Id);
            builder.Property(customer => customer.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(customer => customer.Title).HasMaxLength(maxLength: 200);
            builder.Property(customer => customer.Finished).HasMaxLength(100).IsRequired();
            builder.HasIndex(customer => customer.Finished);
           

            // Relations

        }
    }
}
