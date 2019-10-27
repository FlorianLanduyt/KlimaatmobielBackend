﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Domain.ManyToMany;
using projecten3_1920_backend_klim03.Domain.Models.DTOs;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;

namespace projecten3_1920_backend_klim03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolRepo _schools;

        public SchoolController(ISchoolRepo schools)
        {
            _schools = schools;
        }



        /// <summary>
        /// Get the school with its templates for given id
        /// </summary>
        /// <param name="schoolId">the id of the school</param>
        /// <returns>The school with its templates</returns>
        [HttpGet("withTemplates/{schoolId}")]
        public ActionResult<SchoolDTO> GetClassRoomWithProjects(long schoolId)
        {
            try
            {
                return new SchoolDTO(_schools.GetByIdWithTemplates(schoolId));
            }
            catch (ArgumentNullException)
            {
                return NotFound(new CustomErrorDTO("School niet gevonden"));
            }        
        }




        /// <summary>
        /// Adding a project template to a given school
        /// </summary>
        /// <param name="dto">The project template details</param>
        /// <param name="schoolId">the id of the school</param>
        /// <returns>The added project template</returns>
        [HttpPost("addProjectTemplate/{schoolId}")]
        public ActionResult<ProjectTemplateDTO> AddProject([FromBody]ProjectTemplateDTO dto, long schoolId)
        {
            try
            {
                School s = _schools.GetById(schoolId);
                ProjectTemplate pt = new ProjectTemplate(dto, true); // boolean (addedByGO) dependant on logged in user

                s.AddProjectTemplate(pt);
                _schools.SaveChanges();

                return new ProjectTemplateDTO(pt);
            }
            catch (ArgumentNullException)
            {
                return NotFound(new CustomErrorDTO("School niet gevonden"));
            }
           
        }

        /// <summary>
        /// Adding a product template to a given school
        /// </summary>
        /// <param name="dto">The product template details</param>
        /// <param name="schoolId">the id of the school</param>
        /// <returns>The added product template</returns>
        [HttpPost("addProductTemplate/{schoolId}")]
        public ActionResult<ProductTemplateDTO> AddProductTemplate([FromBody]ProductTemplateDTO dto, long schoolId)
        {
            try
            {
                School s = _schools.GetById(schoolId);
                ProductTemplate pt = new ProductTemplate(dto, true); // boolean (addedByGO) dependant on logged in user

                s.AddProductTemplate(pt);
                _schools.SaveChanges();

                return new ProductTemplateDTO(pt);
            }
            catch (ArgumentNullException)
            {
                return NotFound(new CustomErrorDTO("School niet gevonden"));
            }
          
        }

    }
}