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
            var data = new List<CourseCategory>
            {
                new CourseCategory() {Id = 1, Title = "Web Programming",ChildCategories = new List<CourseCategory>()
                {
                    new CourseCategory(){Id = 10,Title = "ASP.NET Core"}
                }},
                new CourseCategory() {Id = 2, Title = "Mobile Programming",ChildCategories = new List<CourseCategory>()
                {
                    new CourseCategory(){Id = 20,Title = "IOS"}
                }},
                new CourseCategory() {Id = 3, Title = "Desktop Programming",ChildCategories = new List<CourseCategory>()
                    {
                        new CourseCategory(){Id = 21,Title = "C#"}

                    }
                }};
            return Ok(data);
        }

    }
}
