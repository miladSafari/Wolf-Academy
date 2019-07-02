using System;
using Academy.Application.Contract;
using Academy.Domain.Model;
using Academy.Domain.Repository;

namespace Academy.Application
{
    public class CourseCategoryService: ICourseCategoryService
    {
        private readonly ICourseCategoryRepository _repository;
        public CourseCategoryService(ICourseCategoryRepository repository)
        {
            this._repository = repository;
        }
        public void Create(string title)
        {
            var courseCategory=new CourseCategory()
            {
                Title = title
            };
            _repository.Add(courseCategory);
        }
    }
} 
