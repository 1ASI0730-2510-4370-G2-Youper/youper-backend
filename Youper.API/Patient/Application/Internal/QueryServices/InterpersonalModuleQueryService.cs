using Youper.API.Patient.Domain.Model.Queries;
using Youper.API.Patient.Domain.Model.Repositories;

namespace Youper.API.Patient.Application.Internal.QueryServices;

public class InterpersonalModuleQueryService(IInterpersonalModuleRepository interpersonalModuleRepository)
{
    public async Task<object> HandleAsync(GetAllInterpersonalItemsQuery query)
    {
        var recommendations = await interpersonalModuleRepository.GetRecommendationsAsync();
        var videos = await interpersonalModuleRepository.GetVideosAsync();
        var musics = await interpersonalModuleRepository.GetMusicsAsync();

        return new
        {
            Recommendations = recommendations,
            Videos = videos,
            Musics = musics
        };
    }
}