using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2_huseyingulerman.Core.DTOs;
using week2_huseyingulerman.Core.DTOs.Create;
using week2_huseyingulerman.Core.Entities;
using week2_huseyingulerman.Core.Services;
using week2_huseyingulerman.Core.UnitOfWork;

namespace week2_huseyingulerman.Service.Services
{
    public class SatellitesService : Service<Satellites, SatellitesCreateDTO, SatellitesDTO>,ISatellitesService
    {
        public SatellitesService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }
    }
}
