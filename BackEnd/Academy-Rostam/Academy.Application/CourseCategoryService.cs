using System;
using Academy.Domain.Model;

namespace Academy.Application
{
    public class CourseCategoryService
    {
        public void Create(string title)
        {
            var courseCategory = new CourseCategory()
            {
                Title = title
            };
            //.... Save CourseCategory Into DataBase
        }
    }
}
