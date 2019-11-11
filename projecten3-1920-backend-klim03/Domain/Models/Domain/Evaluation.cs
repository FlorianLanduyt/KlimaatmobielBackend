﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Evaluation
    {
        public long EvaluationId { get; set; }

        public string Title { get; set; }
        public string DescriptionPrivate { get; set; }
        public string DescriptionPupil { get; set; }

        public bool Extra { get; set; } // deze die nog niet als standaard bij een project zijn geconfigureerd


        public Evaluation()
        {

        }
    }
}
