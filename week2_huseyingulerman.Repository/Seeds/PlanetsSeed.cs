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
    public class PlanetsSeed : IEntityTypeConfiguration<Planets>
    {
        public void Configure(EntityTypeBuilder<Planets> builder)
        {
            builder.HasData(new Planets { Id = 1, Name = "Earth" ,Temperature=35,Weather="Rainy",Status=Status.Added,IsActive=true}, new Planets { Id = 2, Name = "Mercury", Temperature=-100, Weather="Icy", Status=Status.Added, IsActive=true }, new Planets { Id = 3, Name = "Venus", Temperature=200, Weather="Hot", Status=Status.Added, IsActive=true }, new Planets { Id = 4, Name = "Mars", Temperature=3, Weather="Foggy", Status=Status.Added ,IsActive=true }, new Planets { Id = 5, Name = "Jupiter", Temperature=50, Weather="Clear Sky", Status=Status.Added, IsActive=true });
        }
    }
}
