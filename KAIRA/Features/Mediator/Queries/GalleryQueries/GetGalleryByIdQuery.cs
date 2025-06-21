using KAIRA.Features.Mediator.Results.GalleryResults;
using MediatR;

namespace KAIRA.Features.Mediator.Queries.GalleryQueries;

public class GetGalleryByIdQuery(int id): IRequest<GetGalleryByIdQueryResult>
{
    public int Id { get; set; } =id;
}
