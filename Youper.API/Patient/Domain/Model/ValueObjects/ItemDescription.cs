namespace Youper.API.Patient.Domain.Model.ValueObjects;

public record ItemDescription(string Description)
{
    public ItemDescription() : this(string.Empty)
    {
        
    }
}