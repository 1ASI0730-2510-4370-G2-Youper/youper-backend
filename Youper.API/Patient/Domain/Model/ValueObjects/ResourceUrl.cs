namespace Youper.API.Patient.Domain.Model.ValueObjects;

public record ResourceUrl(string Url)
{
    public ResourceUrl() : this(string.Empty)
    {
        
    }
}