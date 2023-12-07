using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2_huseyingulerman.Core.Entities;
using week2_huseyingulerman.Core.Enums;

namespace week2_huseyingulerman.Repository.Seeds
{
    public class SatellitesSeed : IEntityTypeConfiguration<Satellites>
    {
        public void Configure(EntityTypeBuilder<Satellites> builder)
        {
            builder.HasData(new Satellites { Id = 1, Name = "Moon", Temperature=80, Weather="Warm", Status=Status.Added, IsActive=true }, new Satellites { Id = 2, Name = "Callisto", Temperature=-1, Weather="Sleeting", Status=Status.Added, IsActive=true }, new Satellites { Id = 3, Name = "Europa", Temperature=4, Weather="Lighting", Status=Status.Added, IsActive=true }, new Satellites { Id = 4, Name = "Deimos", Temperature=3, Weather="Tornado", Status=Status.Added, IsActive=true }, new Satellites { Id = 5, Name = "Ariel", Temperature=-3, Weather="Cloudy", Status=Status.Added, IsActive=true });
        }
    }
}
