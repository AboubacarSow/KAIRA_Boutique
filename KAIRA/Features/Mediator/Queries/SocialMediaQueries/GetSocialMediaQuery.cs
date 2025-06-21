using KAIRA.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace KAIRA.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery: IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}
