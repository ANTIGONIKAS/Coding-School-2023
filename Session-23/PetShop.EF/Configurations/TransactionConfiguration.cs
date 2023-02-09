using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PetShop.Model;

namespace PetShop.EF.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            // Table Name
            builder.ToTable("Transaction","PetShop");

            // Primary Key
            builder.HasKey(transaction => transaction.Id);
            builder.Property(transaction => transaction.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(transaction => transaction.Date).IsRequired();
            builder.Property(transaction => transaction.PetPrice).HasPrecision(4, 2).IsRequired();
            builder.Property(transaction=> transaction.PetFoodQty).IsRequired();
            builder.Property(transaction => transaction.PetFoodPrice).HasPrecision(4, 2).IsRequired();
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(5, 2).IsRequired();

            // Relations
            builder.HasOne(transaction => transaction.Customer)
                .WithMany(transaction => transaction.Transactions)
                .HasForeignKey(transaction => transaction.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(transaction => transaction.Employee)
                .WithMany(transaction => transaction.Transactions)
                .HasForeignKey(transaction => transaction.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(transaction => transaction.Pet ) 
            
                .WithMany(transaction => transaction.Transactions)
                .HasForeignKey(transaction => transaction.PetId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(transaction => transaction.PetFood)
                .WithMany(transaction => transaction.Transactions)
                .HasForeignKey(transaction => transaction.PetFoodId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
