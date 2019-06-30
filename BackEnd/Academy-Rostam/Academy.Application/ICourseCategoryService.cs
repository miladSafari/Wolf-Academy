using System;
using System.Collections.Generic;
using System.Text;
using Academy.Domain.Model;

namespace Academy.Application
{
    public interface ICourseCategoryService
    {
        void Create(string title);
    }
}
