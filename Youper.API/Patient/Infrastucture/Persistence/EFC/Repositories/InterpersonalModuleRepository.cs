using Microsoft.EntityFrameworkCore;
using Youper.API.Patient.Domain.Model.Aggregates;
using Youper.API.Patient.Domain.Model.Entities;
using Youper.API.Patient.Domain.Model.Repositories;
using Youper.API.Shared.Infrastuctures.Persistance.EFC.Configuration;
using Youper.API.Shared.Infrastuctures.Persistance.EFC.Repositories;

namespace Youper.API.Patient.Infrastucture.Persistence.EFC.Repositories;

public class InterpersonalModuleRepository
{
    private readonly AppDbContext _context;

    public InterpersonalModuleRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Recommendation>> GetRecommendationsAsync() =>
        await _context.Recommendations.ToListAsync();

    public async Task<IEnumerable<Video>> GetVideosAsync() =>
        await _context.Videos.ToListAsync();

    public async Task<IEnumerable<Music>> GetMusicsAsync() =>
        await _context.Musics.ToListAsync();

    public async Task AddRecommendationAsync(Recommendation recommendation)
    {
        await _context.Recommendations.AddAsync(recommendation);
        await _context.SaveChangesAsync();
    }

    public async Task AddVideoAsync(Video video)
    {
        await _context.Videos.AddAsync(video);
        await _context.SaveChangesAsync();
    }

    public async Task AddMusicAsync(Music music)
    {
        await _context.Musics.AddAsync(music);
        await _context.SaveChangesAsync();
    }
}