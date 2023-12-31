﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2_huseyingulerman.Core.Enums;
using week2_huseyingulerman.Core.Interfaces;

namespace week2_huseyingulerman.Core.Entities
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set ; }
        public string Name { get; set; }
        public int Temperature { get; set; }
        public string Weather { get; set; }
        public bool IsActive { get; set ; }
        public Status Status { get ; set; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime? ModifiedDate { get ; set; }
        public DateTime? DeletedDate { get; set ; }
    }
}
