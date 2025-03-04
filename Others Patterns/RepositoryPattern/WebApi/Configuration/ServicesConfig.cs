using Domain.Interfaces;
using Infra.Repository;
using Infra.UnitOfWorks;

namespace WebApi.Configuration {
    public static class ServicesConfig {

        public static void RegisterServices(this IServiceCollection services) {
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}