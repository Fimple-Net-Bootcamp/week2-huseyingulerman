﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_huseyingulerman.Core.DTOs.Create
{
    public class SatellitesCreateDTO
    {


        public string Name { get; set; }
        public int Temperature { get; set; }
        public string Weather { get; set; }
        public bool IsActive { get; set; }
    }
}
