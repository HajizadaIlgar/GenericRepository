namespace GenericRepositoryAPI.Services.Abstraction
{
    public interface IGroupService
    {
        Task<List<Group>> GetAllGroupAsync();
    }
}
