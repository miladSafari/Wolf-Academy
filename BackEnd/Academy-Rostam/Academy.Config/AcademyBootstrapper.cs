using System;
using Academy.Application;
using Academy.Application.Contract;
using Academy.Domain.Repository;
using Academy.Persistence.EF;
using Microsoft.Extensions.DependencyInjection;

namespace Academy.Config
{
    public static class AcademyBootstrapper
    {
        public static void WireUp(IServiceCollection services)
        {
            //TODO: SingleTone ?? O_o
            services.AddSingleton<ICourseCategoryService, CourseCategoryService>();
            services.AddSingleton<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddSingleton<AcademyContext>();
        }
    }
}
