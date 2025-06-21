using KAIRA.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace KAIRA.Features.Mediator.Queries.SocialMediaQueries;

public class GetSocialMediaByIdQuery(int id): IRequest<GetSocialMediaByIdQueryResult>
{
    public int Id { get; set; } = id;
}
