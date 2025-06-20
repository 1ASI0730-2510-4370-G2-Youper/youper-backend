namespace Youper.API.Patient.Domain.Model.ValueObjects;

public record ItemType(string Type)
{
    public ItemType() : this(string.Empty)
    {
        
    }
}