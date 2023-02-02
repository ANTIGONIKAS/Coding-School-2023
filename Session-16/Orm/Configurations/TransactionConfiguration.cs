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
          builder.Property(transaction => transaction.TransactionID);
          builder.Property(transaction => transaction.TransactionDate);
          builder.Property(transaction => transaction.PetPrice).HasPrecision(10);
     
           
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(10);
            builder.Property(transaction => transaction.CustomerID);
            builder.Property(transaction => transaction.EmployeeID);
            builder.Property(transaction => transaction.PetID);
            builder.Property(transaction => transaction.PetFood);
            builder.Property(transaction => transaction.PetFoodID);

            builder.Property(transaction => transaction.TransactionLines);


                   //Relations OneToOne
                   //customer
            builder.HasOne(transaction => transaction.Customer).WithOne(customer => customer.Transaction)
                    .HasForeignKey<Transaction>(customer => customer.CustomerID);
                  //employee
            builder.HasOne(transaction => transaction.Employee).WithOne(employee => employee.Transaction)
                           .HasForeignKey<Employee>(employee => employee.EmployeeID);
                 //pet
            builder.HasOne(transaction => transaction.Pet).WithOne(pet => pet.Transaction)
                          .HasForeignKey<Pet>(pet => pet.PetID);//?line

            builder.HasOne(transaction => transaction.PetFood).WithOne(petFood => petFood.Transaction).HasForeignKey<PetFood>(petfood => petfood.PetFoodID);

            //OneToMany Customer...transactions

            builder.HasOne(transaction => transaction.Customer).WithMany(customer => customer.Transactions).
                HasForeignKey(transaction => transaction.CustomerID);



        }
    }
}
