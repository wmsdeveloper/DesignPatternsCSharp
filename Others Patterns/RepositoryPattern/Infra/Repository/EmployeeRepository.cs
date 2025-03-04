using Domain.Entities;
using Domain.Interfaces;

namespace Infra.Repository {
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository {

        public EmployeeRepository(ApplicationContext context) : base(context) {

        }

        public async Task<IEnumerable<Employee>> GetBySalaryAsync(double from, double to) {
            //return _context.Employee.OrderByDescending(p => p.Salary >= from && p.Salary <= to).ToList();
            return await Task.Run(() => _context.Employee.OrderByDescending(p => p.Salary >= from && p.Salary <= to).ToList());
        }
    }
}