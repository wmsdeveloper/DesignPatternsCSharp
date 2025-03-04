namespace Domain.Interfaces {
    public interface IUnitOfWork : IDisposable {
        IEmployeeRepository Employee { get; }
        int Commit();
        Task<int> CommitAsync();
    }
}