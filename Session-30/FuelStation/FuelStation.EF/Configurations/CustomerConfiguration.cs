using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //table
            builder.ToTable("Customers");
            //primary key
            builder.HasKey(c => c.Id);

            //properties
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Surname).IsRequired().HasMaxLength(50);
            builder.Property(c => c.CardNumber).IsRequired().HasMaxLength(50);
        }
    }
}

