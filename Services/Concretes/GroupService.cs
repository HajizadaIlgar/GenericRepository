
namespace GenericRepositoryAPI.Services.Concretes
{
    public class GroupService : IGroupService
    {
        private readonly ITRepository<Group> _repository;
        public GroupService(ITRepository<Group> repository)
        {
            _repository = repository;
        }
        public async Task<List<Group>> GetAllGroupAsync()
        {
            IQueryable<Group> queryableGroup = _repository.GetAllT(false, "Student", "Teacher");
            List<Group> result = await queryableGroup.ToListAsync();
            return result;
        }
    }
}
