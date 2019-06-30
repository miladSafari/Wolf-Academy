using System;
using Academy.Application;
using Academy.Domain.Repository;
using Academy.Persistence.EF;
using Microsoft.Extensions.DependencyInjection;

namespace Academy.Config
{
    public static class AcademyBootstrapper
    {
        public static void WireUp(IServiceCollection services)
        {
            services.AddSingleton<ICourseCategoryService, CourseCategoryService>();
            services.AddSingleton<ICourseCategoryRepository, CourseCategoryRepository>();
        }
    }
}
