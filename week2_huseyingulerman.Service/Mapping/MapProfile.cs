using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2_huseyingulerman.Core.DTOs;
using week2_huseyingulerman.Core.DTOs.Create;
using week2_huseyingulerman.Core.Entities;

namespace week2_huseyingulerman.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Planets, PlanetsDTO>();
            CreateMap<PlanetsCreateDTO, Planets>();
            CreateMap<PlanetsDTO, PlanetsCreateDTO>();
            CreateMap<PlanetsCreateDTO,PlanetsDTO >();
            CreateMap<Satellites, SatellitesDTO>();
            CreateMap<SatellitesCreateDTO, Satellites>();

        }
    }
}
