using EventyApp.Service.Classess;
using EventyApp.Service.Interface;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

namespace EventyApp.Extentions
{
    public static class DefendenceRegistration
    {
        public static void AddDefendenceRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient();
            services.AddLogging();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                });
                options.OperationFilter<SecurityRequirementsOperationFilter>();
            });
            services.AddHttpClient();
            services.AddAutoMapper(typeof(Program).Assembly);
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IEventService, EventService>();
        }
    }
}
