using Domain.Entities;

namespace Domain.Interfaces {
    public interface IEmployeeRepository : IGenericRepository<Employee> {
        Task<IEnumerable<Employee>> GetBySalaryAsync(double from, double to);
    }
}