﻿using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Domain.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models
{
    public class Pupil
    {
        public long PupilId { get; set; }


        public string FirstName { get; set; }
        public string Surname { get; set; }

        //te restrictief?
        /*public long ClassRoomId { get; set; } 
        public ClassRoom ClassRoom { get; set; }*/

        public long SchoolId { get; set; }
        public School School { get; set; }

        public List<PupilGroup> PupilGroups { get; set; } = new List<PupilGroup>();


        public Pupil()
        {

        }




    }
}
