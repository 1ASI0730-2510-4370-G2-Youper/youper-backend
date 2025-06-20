using Youper.API.Patient.Domain.Model.Commands;
using Youper.API.Patient.Domain.Model.Entities;
using Youper.API.Patient.Domain.Model.Repositories;
using Youper.API.Patient.Domain.Model.ValueObjects;
using Youper.API.Shared.Domain.Repositories;

namespace Youper.API.Patient.Application.Internal.CommandServices;

public class InterpersonalModuleCommandService(
    IInterpersonalModuleRepository interpersonalModuleRepository,
    IUnitOfWork unitOfWork)
{
    public async Task<object?> Handle(CreateInterpersonalItemCommand command)
    {
        var url = new ResourceUrl(command.Url);

        try
        {
            switch (command.Type.ToLower())
            {
                case "recommendation":
                    var recommendation = new Recommendation(command.Title, command.Type, url);
                    await interpersonalModuleRepository.AddRecommendationAsync(recommendation);
                    break;

                case "video":
                    var video = new Video(command.Title, url);
                    await interpersonalModuleRepository.AddVideoAsync(video);
                    break;

                case "music":
                    var music = new Music(command.Title, url);
                    await interpersonalModuleRepository.AddMusicAsync(music);
                    break;

                default:
                    throw new ArgumentException("Unsupported resource type: " + command.Type);
            }

            await unitOfWork.CompleteAsync();
            return new { Success = true };
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}