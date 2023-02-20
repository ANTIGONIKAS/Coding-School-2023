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
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            //table
            builder.ToTable("TransactionLines");

            //primarykey
            builder.HasKey(t => t.Id);

            //properties
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.Quantity).IsRequired();
            builder.Property(t => t.ItemPrice).HasPrecision(10, 2).IsRequired();
            builder.Property(t => t.NetValue).HasPrecision(10, 2).IsRequired();
            builder.Property(t => t.DiscountPercent).HasPrecision(4, 2).IsRequired();
            builder.Property(t => t.DiscountValue).HasPrecision(4, 2).IsRequired();
            builder.Property(t => t.TotalValue).HasPrecision(10, 2).IsRequired();

            //relations
            builder.HasOne(t => t.Transaction).WithMany(t => t.TransactionLines)
           .HasForeignKey(t => t.TransactionId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Item).WithMany(t => t.TransactionLines)
           .HasForeignKey(t => t.ItemId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
