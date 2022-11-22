using ICH.BLL.Interfaces.Logger;
using ICH.BLL.Interfaces.User;
using ICH.BLL.Interfaces.Vacancy;
using ICH.BLL.Services.Logger;
using ICH.BLL.Services.User;
using ICH.BLL.Services.Vacancy;
using ICH.DAL.Repositories.Interfaces.Base;
using ICH.DAL.Repositories.Interfaces.User;
using ICH.DAL.Repositories.Interfaces.Vacancy;
using ICH.DAL.Repositories.Realizations.Base;
using ICH.DAL.Repositories.Realizations.User;
using ICH.DAL.Repositories.Realizations.Vacancy;

namespace ICH.Server
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IVacancyRepository, VacancyRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IEmploymentTypeRepository, EmploymentTypeRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ISpecialCategoryRepository, SpecialCategoryRepository>();
            services.AddScoped<IWorkTypeRepository, WorkTypeRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IVacancyService, VacancyService>();
            
            services.AddSingleton<ILoggerManager, LoggerManager>();
            
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            return services;
        }
    }
}
