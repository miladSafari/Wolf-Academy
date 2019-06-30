using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
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
        public void Post()
        {
            _service.Create("Web Developer"); 
        }
        
    }
}
