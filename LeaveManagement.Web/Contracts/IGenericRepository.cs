namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetAsync(int? id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> ExistAsync(int id);
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);

    }
}
