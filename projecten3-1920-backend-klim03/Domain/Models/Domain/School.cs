﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class School
    {
        public long SchoolId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNum { get; set; }

        public long AdresId { get; set; }
        public Adres Adres { get; set; }

        public ICollection<ClassRoom> ClassRooms { get; set; } = new List<ClassRoom>();

        public ICollection<ProjectTemplate> ProjectTemplates { get; set; } = new List<ProjectTemplate>();
        public ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();

        public School()
        {

        }
    }
}
