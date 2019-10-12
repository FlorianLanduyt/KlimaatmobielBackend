﻿using System;
using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepo _projecten;

        public ProjectController(IProjectRepo projecten)
        {
            _projecten = projecten;
        }
    }
}
