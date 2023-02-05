using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Orm.Configurations
{
   




    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLine");
            builder.HasKey(transactionLine => transactionLine.TransactionLineID);
            builder.Property(transactionLine => transactionLine.TransactionLineID).ValueGeneratedOnAdd();

            builder.Property(transactionLine => transactionLine.PetFoodQty).IsRequired(true);
            builder.Property(transactionLine => transactionLine.PetFoodPrice).HasPrecision(10, 2);
            builder.Property(transactionLine => transactionLine.PetFoodCost).HasPrecision(10, 2).IsRequired(true);
            builder.Property(transactionLine => transactionLine.LineTotal).HasPrecision(10, 2);
            builder.Property(transactionLine => transactionLine.PetPrice).HasPrecision(10, 2).IsRequired(true);

            builder.Property(transactionLine => transactionLine.TransactionID);
            builder.Property(transactionLine => transactionLine.PetFoodID);
            builder.Property(transactionLine => transactionLine.PetID);
            builder.Property(transactionLine => transactionLine.SpecialOfferID);

            builder.HasOne(transactionLine => transactionLine.Transastion).WithMany(transaction => transaction.TransactionLines).
                HasForeignKey(transactionLine => transactionLine.TransactionID);

            builder.HasOne(transactionLine => transactionLine.PetFood).WithOne(petFood => petFood.TransactionLine)
                .HasForeignKey<TransactionLine>(transactionLine => transactionLine.PetFoodID);

            builder.HasOne(transactionLine => transactionLine.SpecialOffer).WithOne(specialOffer => specialOffer.TransactionLine)
                .HasForeignKey<TransactionLine>(transactionLine => transactionLine.SpecialOfferID);







        }
    }
}