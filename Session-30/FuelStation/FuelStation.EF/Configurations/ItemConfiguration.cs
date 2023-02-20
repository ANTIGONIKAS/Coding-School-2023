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
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            //table
            builder.ToTable("Items");

            //primarykey
            builder.HasKey(i => i.Id);
            //properties
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i => i.Code).HasMaxLength(20).IsRequired();
            builder.Property(i => i.Description).HasMaxLength(150).IsRequired();
            builder.Property(i => i.Price).HasPrecision(10, 2).IsRequired();
            builder.Property(i => i.Cost).HasPrecision(10, 2).IsRequired();
            builder.Property(i => i.ItemType).IsRequired();
        }
    }
}
