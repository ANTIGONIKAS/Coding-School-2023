using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PetShop.Model;

namespace PetShop.EF.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Table Name
            builder.ToTable("Employee","PetShop");

         
            builder.HasKey(employee => employee.Id);
            builder.Property(employee => employee.Id).ValueGeneratedOnAdd();
         

            
            builder.Property(employee=> employee.Title).HasMaxLength(maxLength: 200);
            builder.HasIndex(employee=>employee.Finished);
            

      
        }
    }
}
