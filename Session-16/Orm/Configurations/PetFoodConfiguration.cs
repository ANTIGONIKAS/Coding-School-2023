using F.Session_16.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configurations
{
    public class PetFoodConfiguration : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
         builder.ToTable("PetFood");

            builder.HasKey(petfood => petfood.PetFoodID);
        }
    }
}
