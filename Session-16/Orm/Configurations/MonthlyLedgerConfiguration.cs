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
    public class MonthlyLedgerConfiguration : IEntityTypeConfiguration<MonthlyLedger>
    {
        public void Configure(EntityTypeBuilder<MonthlyLedger> builder)
        {
            builder.ToTable("MonthlyLedger");
            builder.HasKey(monthlyLedger => monthlyLedger.MonthlyLedID); 
            builder.Property(monthlyLedger => monthlyLedger.Year).HasMaxLength(4); 
            builder.Property(monthlyLedger => monthlyLedger.Month).HasMaxLength(2); 
            builder.Property(monthlyLedger => monthlyLedger.Income).HasPrecision(20); //??
            builder.Property(monthlyLedger => monthlyLedger.Expenses).HasPrecision(15); 
            builder.Property(monthlyLedger => monthlyLedger.Total).HasPrecision(20); 

        }
    }
}
