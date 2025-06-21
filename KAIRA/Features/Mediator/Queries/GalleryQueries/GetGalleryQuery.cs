using KAIRA.Features.Mediator.Results.GalleryResults;
using MediatR;

namespace KAIRA.Features.Mediator.Queries.GalleryQueries
{
    public class GetGalleryQuery: IRequest<List<GetGalleryQueryResult>>
    {
    }
}
