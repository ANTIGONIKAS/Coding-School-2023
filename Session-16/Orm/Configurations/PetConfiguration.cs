using EF.Session_16.Model;
using F.Session_16.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session_16.Orm.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
           public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");
            builder.HasKey(pet => pet.PetID);
        }
    }
}
