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

        {
            builder.ToTable("Transaction");

            builder.HasKey(transaction => transaction.TransactionID);
            builder.Property(transaction => transaction.TransactionDate).HasMaxLength(50);
            builder.Property(transaction => transaction.CustomerID).HasMaxLength(50);
            builder.Property(transaction => transaction.EmployeeID).HasMaxLength(50);
            //builder.Property(transaction => transaction.PetID).HasMaxLength(30);
            //builder.Property(transaction => transaction.PetFoodID).HasMaxLength(30);


            builder.Property(transaction => transaction.PetPrice).HasPrecision(10);
            builder.Property(transaction => transaction.PetFoodPrice).HasPrecision(10, 5);
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(10, 5);

            //Relation OneToOne

            // customer
            builder.HasOne(transaction => transaction.Customer).WithOne(customer => customer.Transaction)
                    .HasForeignKey<Transaction>(transaction => transaction.CustomerID).OnDelete(DeleteBehavior.SetNull);


            //EMPLOYEE
            builder.HasOne(transaction => transaction.Employee).WithOne(employee => employee.Transaction)
                           .HasForeignKey<Transaction>(transaction => transaction.EmployeeID).OnDelete(DeleteBehavior.SetNull);
            
          


        }
    }

}