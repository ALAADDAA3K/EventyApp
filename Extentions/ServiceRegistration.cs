using EventyApp.Data;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json.Serialization;

namespace EventyApp.Extentions
{
    public static class ServiceRegistration
    {
        public static void AddServicesRegister(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers().AddFluentValidation(v =>
            {
                v.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            });
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddAuthServices(configuration);
            services.AddDefendenceRegistration(configuration);
        }
    }
}
