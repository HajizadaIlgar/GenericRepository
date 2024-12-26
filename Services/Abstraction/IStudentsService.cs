namespace GenericRepositoryAPI.Services.Abstraction
{
    public interface IStudentsService
    {
        Task<List<Student>> GetAllStudentsAsync();
        Student GetStudentById(int id);
    }
}
