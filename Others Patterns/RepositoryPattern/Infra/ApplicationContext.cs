using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra {
    public class ApplicationContext : DbContext {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Employee> Employee { get; set; }
    }
}