using KAIRA.Data.Entities;

namespace KAIRA.Features.CQRS.Results
{
    public class GetCategoryByIdQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        
    }
}
