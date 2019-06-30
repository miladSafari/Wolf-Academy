using System;
using Academy.Domain.Model;
using Academy.Domain.Repository;

namespace Academy.Persistence.EF
{
    public class CourseCategoryRepository : ICourseCategoryRepository
    {
        private readonly AcademyContext _context;
        public CourseCategoryRepository(AcademyContext context)
        {
            this._context = context;
        }
        public void Add(CourseCategory courseCategory)
        {

            _context.CourseCategories.Add(courseCategory);
            _context.SaveChanges();
        }
    }
}
