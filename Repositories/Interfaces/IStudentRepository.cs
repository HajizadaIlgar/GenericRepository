using GenericRepositoryAPI.DALs;

namespace GenericRepositoryAPI.Repositories.Interfaces;

public interface ITRepository<T> where T : BaseEntity, new()
{
    IQueryable<T> GetAllT(bool isTracking, params string[] includes);
}

public class TRepository<T> : ITRepository<T> where T : BaseEntity, new()
{
    public readonly AppDbContext _dbcontext;
    public TRepository(AppDbContext dbContext)
    {
        _dbcontext = dbContext;
        DbSet<T> students = _dbcontext.Set<T>();
    }
    public IQueryable<T> GetAllT(bool isTracking, params string[] includes)
    {
        var query = _dbcontext.Set<T>().AsQueryable();
        if (!isTracking)
        {
            query = query.AsNoTracking();
        }
        if (includes.Length > 0)
        {
            foreach (string include in includes)
            {
                query = query.Include(include);
            }
        }
        return query;
    }
}
