using System;
using System.Collections.Generic;
using System.Text;
using Academy.Domain.Model;

namespace Academy.Domain.Repository
{
    public interface ICourseCategoryRepository
    {
        void Add(CourseCategory courseCategory);
    }
}
