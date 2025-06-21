namespace KAIRA.Features.CQRS.Queries.ServiceQueries
{
    public class GetServiceByIdQuery(int id)
    {
        public int Id { get; } = id;
    }
}
