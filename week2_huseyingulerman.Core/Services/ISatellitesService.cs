using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2_huseyingulerman.Core.DTOs;
using week2_huseyingulerman.Core.DTOs.Create;
using week2_huseyingulerman.Core.Entities;

namespace week2_huseyingulerman.Core.Services
{
    public interface ISatellitesService:IService<Satellites,SatellitesCreateDTO, SatellitesDTO>
    {
    }
}
