using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Configurations
{
    public class EmployeeDetailConfiguration : IEntityTypeConfiguration<EmployeeDetail>
    {
      
        public void Configure(EntityTypeBuilder<EmployeeDetail> builder)
        { 
            builder.ToTable("EmployeeDetail", "PetShop");

            builder.HasKey(employeeDetail => employeeDetail.Id);
            builder.Property(emloyeeDetail => emloyeeDetail.Id).ValueGeneratedOnAdd();
            builder.Property(emloyeeDetail => emloyeeDetail.Name).IsRequired();
            builder.Property(emloyeeDetail => emloyeeDetail.Surname).IsRequired();
            builder.Property(emloyeeDetail => emloyeeDetail.SalaryPerMonth).IsRequired();
            //builder.Property(emloyeeDetail => emloyeeDetail.EmployeeType).ValueGeneratedNever();
         

            builder.HasOne(employeeDetail=>employeeDetail.Employee).
                WithOne(employee=>employee.Detail).
                HasForeignKey<EmployeeDetail>(employeeDetail=>employeeDetail.EmployeeId).IsRequired();


        }
    }
}
