using GenericRepositoryAPI.DALs;
using GenericRepositoryAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryAPI.Services;

public interface IStudentsService
{
    Task<List<Student>> GetAllStudents(bool isTracking = false, params string[] includes);
    Student GetStudents(int id);
}
public class StudentsService : IStudentsService
{
    public readonly AppDbContext _dbcontext;
    public StudentsService(AppDbContext context)
    {
        _dbcontext = context;
    }
    public async Task<List<Student>> GetAllStudents(bool isTracking, params string[] includes)
    {
        var query = _dbcontext.Students.AsQueryable();
        if (!isTracking)
        {
            query = query.AsTracking();
        }
        if (includes.Length > 0)
        {
            foreach (string include in includes)
            {
                query = query.Include(include);
            }
        }
        return query.ToList();
    }

    public Student GetStudents(int id)
    {
        throw new Exception();
    }
}
