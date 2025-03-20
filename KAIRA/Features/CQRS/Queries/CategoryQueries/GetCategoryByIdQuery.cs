namespace KAIRA.Features.CQRS.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery(int id)
    {
        public int Id { get; set; } = id;
    }
}
