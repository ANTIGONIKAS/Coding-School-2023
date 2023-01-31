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
    public class PetReportConfiguration : IEntityTypeConfiguration<PetReport>
    {
        public void Configure(EntityTypeBuilder<PetReport> builder)
        {
            builder.ToTable("PetReport");
            builder.HasKey(petReport=>petReport.ID); 
            builder.Property(petReport=>petReport.Year); 
            builder.Property(petReport=>petReport.TotalSold); 

        }
    }
}
