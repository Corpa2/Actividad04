using System.Linq.Expressions;

namespace actividad04.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<bool> SaveAsync();
    
    // Útil para buscar (ej. por nombre de producto)
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
}