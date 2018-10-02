using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using VoiceProject.Data.Contracts;
using VoiceProject.Data.Services.EF;
using VoiceProject.Domain.Contracts;
using VoiceProject.Domain.Services;

namespace VoiceProject.App.App_Config
{
    public class ConfigurationManager
    {
        private static IServiceCollection _serviceCollection;
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            var _connectionString = configuration.GetConnectionString("DefaultConnection")
                .Replace("{AppDir}", Directory.GetCurrentDirectory());
            services.AddDbContext<VPDBContext>(options =>
            options.UseSqlServer(_connectionString));

            //Data Services
            services.AddTransient<ISurveyDataAccessService, SurveyDataAccessService>();

            //Domain Services
            services.AddTransient<ISurveyService, SurveyService>();
            services.AddTransient<ISurveyEntityToModelMapperService, SurveyEntityToModelMapperService>();

            _serviceCollection = services;
        }
    }
}
