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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //table
            builder.ToTable("Employess");

            //primarykey
            builder.HasKey(e => e.Id);

            //properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(20);
            builder.Property(e => e.Surname).IsRequired().HasMaxLength(20);
            builder.Property(e => e.HireDateStart).IsRequired();
            builder.Property(e => e.HireDateEnd);
            builder.Property(e => e.SalaryPerMonth).HasPrecision(10, 2).IsRequired();
            builder.Property(e => e.EmployeeType).IsRequired();

        }
    }
}
