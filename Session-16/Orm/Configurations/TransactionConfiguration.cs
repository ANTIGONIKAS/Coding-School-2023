using Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session_16.Orm.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        { builder.ToTable("Transaction");
          builder.HasKey(transaction => transaction.TransactionID);
          builder.Property(transaction => transaction.TransactionDate);
          builder.Property(transaction => transaction.PetPrice).HasPrecision(10);
          builder.Property(transaction => transaction.PetFoodID);
            builder.Property(transaction => transaction.PetFoodPrice).HasPrecision(8);
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(10);
            builder.Property(transaction => transaction.Customer.CustomerID);
            builder.Property(transaction => transaction.Employee.EmployeeID);
            builder.Property(transaction => transaction.PetFood);
            builder.Property(transaction => transaction.PetFoodQty);
            builder.Property(transaction => transaction.Pet.PetID);
   



          
        }
    }
}
