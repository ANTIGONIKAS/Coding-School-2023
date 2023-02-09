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
    public class CustomerDetailConfiguration : IEntityTypeConfiguration<CustomerDetail>
    {
        public void Configure(EntityTypeBuilder<CustomerDetail> builder)
        {
            builder.ToTable("CustomerDetail", "PetShop");

            builder.HasKey(customerDetail => customerDetail.Id);
            builder.Property(customerDetail => customerDetail.Id).ValueGeneratedOnAdd();
            builder.Property(customerDetail => customerDetail.Name).IsRequired();
            builder.Property(customerDetail => customerDetail.Surname).IsRequired();
            builder.Property(customerDetail => customerDetail.Phone).IsRequired();
            builder.Property(customerDetail => customerDetail.Tin).IsRequired();

            builder.HasOne(customerDetail => customerDetail.Customer)
                .WithOne(customer => customer.Detail).
                HasForeignKey<CustomerDetail>(customerDetail => customerDetail.CustomerId).IsRequired();





        }

    }

}