using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2_huseyingulerman.Core.DTOs.Create;

namespace week2_huseyingulerman.Core.DTOs.Uptade
{
    public class PlanetsUpdateDTO:PlanetsCreateDTO
    {
        public int Id { get; set; }
    }
}
