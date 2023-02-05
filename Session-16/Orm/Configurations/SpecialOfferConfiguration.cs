using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configurations
{
    public class SpecialOfferConfiguration : IEntityTypeConfiguration<SpecialOffer>
    {
        public void Configure(EntityTypeBuilder<SpecialOffer> builder)
        {
            builder.ToTable("SpecialOffer");
            builder.HasKey(specialOffer => specialOffer.SpecialOfferID);
            builder.Property(specialOffer => specialOffer.SpecialOfferID).ValueGeneratedOnAdd();
            builder.Property(specialOffer => specialOffer.PetFoodID);
            builder.Property(specialOffer => specialOffer.TransactionLineID);
            builder.Property(specialOffer => specialOffer.TransactionLineID);

            builder.HasOne(transaction => transaction.PetFood).WithOne(petFood => petFood.SpecialOffer).
                HasForeignKey<SpecialOffer>(specialOffer => specialOffer.PetFoodID);


        }
    }
}