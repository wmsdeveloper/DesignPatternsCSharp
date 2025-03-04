using Domain.Interfaces;
using Infra.Repository;

namespace Infra.UnitOfWorks {
    public class UnitOfWork : IUnitOfWork {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context) {
            _context = context;
            Employee = new EmployeeRepository(_context);
        }
        public IEmployeeRepository Employee { get; private set; }

        public int Commit() {
            return _context.SaveChanges();
        }

        public async Task<int> CommitAsync() {
            return await _context.SaveChangesAsync();
        }

        public void Dispose() {
            _context.Dispose();
        }
    }
}