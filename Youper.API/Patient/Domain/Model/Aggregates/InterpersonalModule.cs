using Youper.API.Patient.Domain.Model.Entities;

namespace Youper.API.Patient.Domain.Model.Aggregates;

public class InterpersonalModule
{
    public int Id { get; private set; }
    public List<Recommendation> Recommendations { get; private set; } = new();
    public List<Video> Videos { get; private set; } = new();
    public List<Music> MusicTracks { get; private set; } = new();

    public void AddRecommendation(Recommendation rec) => Recommendations.Add(rec);
    public void AddVideo(Video video) => Videos.Add(video);
    public void AddMusic(Music music) => MusicTracks.Add(music);
}