using Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
           public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");
            builder.HasKey(pet => pet.PetID);
           
            builder.Property(pet => pet.Breed).HasMaxLength(20);
            builder.Property(pet => pet.PetStatus);
            builder.Property(pet => pet.Cost).HasPrecision(5);
            builder.Property(pet => pet.Price).HasPrecision(10);
            builder.Property(pet => pet.PetFood);
            builder.Property(pet => pet.Transaction.TransactionID); 



        }
    }
}
