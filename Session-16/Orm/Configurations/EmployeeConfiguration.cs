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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(employee=>employee.EmployeeID);
            builder.Property(Employee => Employee.EmployeeName).HasMaxLength(10);
            builder.Property(Employee => Employee.EmployeeSurname).HasMaxLength(10);
            builder.Property(Employee => Employee.SalaryPerMonth).HasPrecision(6);
           
            
            
            
            




        }
    }
}

