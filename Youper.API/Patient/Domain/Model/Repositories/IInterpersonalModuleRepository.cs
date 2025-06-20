using Youper.API.Patient.Domain.Model.Entities;

namespace Youper.API.Patient.Domain.Model.Repositories;

public interface IInterpersonalModuleRepository
{
    Task<IEnumerable<Recommendation>> GetRecommendationsAsync();
    Task<IEnumerable<Video>> GetVideosAsync();
    Task<IEnumerable<Music>> GetMusicsAsync();

    Task AddRecommendationAsync(Recommendation recommendation);
    Task AddVideoAsync(Video video);
    Task AddMusicAsync(Music music);
}