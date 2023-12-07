using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2_huseyingulerman.Core.Enums;

namespace week2_huseyingulerman.Core.DTOs
{
    public class PlanetsDTO
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public int Temperature { get; set; }
        public string Weather { get; set; }
   
    }
}
