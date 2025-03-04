using Infra;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Configuration {
    public static class ApiConfig {

        public static void AddApiConfiguration(this IServiceCollection services, IConfiguration configuration) {
            services.AddDbContext<ApplicationContext>(opt => opt.UseInMemoryDatabase("ConnectionStrings"));

            // Add services to the container.
            services.AddControllers();
            services.AddAuthorization();
            services.AddOpenApi();
        }

        public static void UseApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseRouting();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
