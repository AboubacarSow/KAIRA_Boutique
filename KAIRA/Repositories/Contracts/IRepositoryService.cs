namespace KAIRA.Repositories.Contracts
{
    public interface IRepositoryService
    {
        ICategoryRepository Category { get; }
        void SaveChanges();

    }
}
