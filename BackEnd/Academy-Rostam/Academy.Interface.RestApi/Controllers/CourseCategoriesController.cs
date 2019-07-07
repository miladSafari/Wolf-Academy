using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
using Academy.Application.Contract;
using Academy.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Interface.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController : ControllerBase
    {
        private readonly ICourseCategoryService _service;

        public CourseCategoriesController(ICourseCategoryService service)
        {
            _service = service;
        }

        public IActionResult Get()
        {
            var data = new List<Course>
            {
                new Course() {Id = 1, Title = "Web Programming"},
                new Course() {Id = 2, Title = "Mobile Programming"},
                new Course() {Id = 3, Title = "Desktop Programming"}
            };
            return Ok(data);
        }
        
    }
}
