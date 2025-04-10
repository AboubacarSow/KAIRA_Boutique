namespace KAIRA.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        ICategoryRepository Category { get; }
       IProductRepository Product { get; }

    }
}
