using KAIRA.Data.Entities;

namespace KAIRA.Features.CQRS.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
