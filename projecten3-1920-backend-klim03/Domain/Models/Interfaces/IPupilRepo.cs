﻿using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Interfaces
{
    public interface IPupilRepo : IGenericRepo<Pupil>
    {
        bool PupilExists(string firstname, string surname, long schoolId);
        Pupil GetByName(string firstname, string surname, long schoolId);
    }
}
