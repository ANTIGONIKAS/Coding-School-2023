
using EF.Session_16.Model;
using F.Session_16.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session_16.Orm.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
        {
            //tha ftiaxei ena pinaka customers
            builder.ToTable("Customer");
            builder.HasKey(customer => customer.CustomerID);  //einai swsto?mporw na to xrhsimopoihsw san primary key?
            builder.Property(customer => customer.Phone).HasMaxLength(20).IsRequired(true);
            builder.Property(customer => customer.Name).HasMaxLength(15).IsRequired(true);
            builder.Property(customer => customer.Surname).HasMaxLength(15).IsRequired(true);
            builder.Property(customer => customer.TIN).HasMaxLength(15).IsRequired(true);
            builder.HasOne(customer => customer.Transaction).WithOne(transaction => transaction.Customer)
                    .HasForeignKey<Transaction>(customer => customer.CustomerID);




        }
    }
}
