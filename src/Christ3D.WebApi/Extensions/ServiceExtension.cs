using Christ3D.Application.Interfaces;
using Christ3D.Application.Services;
using Christ3D.Domain.Interfaces;
using Christ3D.Infrastruct.Data.Context;
using Christ3D.Infrastruct.Data.DataRepository;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Christ3D.WebApi.Extensions
{
    public static class ServiceExtension
    {

        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {

            // 注入 Application 应用层
            services.AddScoped<IStudentAppService, StudentAppService>();


            // 注入 Infra - Data 基础设施数据层
            services.AddScoped<IStudentRepository, StudentRepository>();
            //services.AddScoped<StudyContext>();//上下文
            services.AddDbContext<StudyContext>(options =>
            {

                options.UseMySql(configuration.GetSection("ConnectionStrings:DefaultConnection").Get<string>(), ServerVersion.Create(8, 0, 22, ServerType.MySql));
            });

        }
    }
}
