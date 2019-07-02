using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
using Academy.Application.Contract;
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
        public IActionResult Post()
        {
            _service.Create("Web Developer");
            return Accepted();
        }
        
    }
}
