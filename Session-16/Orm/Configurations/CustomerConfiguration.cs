
using Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<CustomerF>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomerF> builder)
        {
            //tha ftiaxei ena pinaka customers
            builder.ToTable("Customer");
            builder.HasKey(customer => customer.CustomerID);  
            builder.Property(customer => customer.Phone).HasMaxLength(20).IsRequired(true);
            builder.Property(customer => customer.CustomerName).HasMaxLength(12).IsRequired(true);
            builder.Property(customer => customer.CustomerSurname).HasMaxLength(12).IsRequired(true);
            builder.Property(customer => customer.TIN).HasMaxLength(10).IsRequired(true);



         


        }
    }
}
