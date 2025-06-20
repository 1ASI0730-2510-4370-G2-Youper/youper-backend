namespace Youper.API.Patient.Domain.Model.Commands;

public record CreateInterpersonalItemCommand(
        string Title,
        string Type,
        string Url
    );