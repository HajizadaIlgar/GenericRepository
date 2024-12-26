using GenericRepositoryAPI.Services;
using GenericRepositoryAPI.Services.Concretes;

namespace GenericRepositoryAPI
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentsService, StudentsService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<ITRepository<Student>, TRepository<Student>>();
            services.AddScoped<ITRepository<Group>, TRepository<Group>>();
            return services;
        }
    }
}
