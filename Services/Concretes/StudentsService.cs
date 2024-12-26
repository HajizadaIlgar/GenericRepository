namespace GenericRepositoryAPI.Services;

public class StudentsService : IStudentsService
{
    public readonly ITRepository<Student> _studentRepository;
    public StudentsService(ITRepository<Student> studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public async Task<List<Student>> GetAllStudentsAsync()
    {
        IQueryable<Student> queryablestudents = _studentRepository.GetAllT(false, "Group");
        List<Student> students = await queryablestudents.ToListAsync();
        return students;
    }

    public Student GetStudentById(int id)
    {
        throw new NotImplementedException();
    }
}

//public interface IGroupsService
//{
//    Task<List<Group>> GetAllGroups(bool isTracking = false, params string[] includes);
//    Group GetGroupById(int id);
//}
//public class GroupsService : IGroupsService
//{
//    private readonly AppDbContext _dbcontext;
//    private readonly IStudentRepository _repository;

//    public GroupsService(AppDbContext context, IStudentRepository repository)
//    {
//        _dbcontext = context;
//        _repository = repository;
//    }
//    public async Task<List<Group>> GetAllGroups()
//    {
//        List<Group> students = await query.ToListAsync();
//        return students;
//    }

//    public Task<List<Group>> GetAllGroups(bool isTracking = false, params string[] includes)
//    {
//        throw new NotImplementedException();
//    }

//    public Group GetGroupById(int id)
//    {
//        throw new NotImplementedException();
//    }

//}
