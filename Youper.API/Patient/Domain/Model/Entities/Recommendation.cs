using Youper.API.Patient.Domain.Model.ValueObjects;

namespace Youper.API.Patient.Domain.Model.Entities;

public class Recommendation
{
    public int Id { get; set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public ResourceUrl Url { get; private set; }

    public Recommendation()
    {
        Title = string.Empty;
        Description = string.Empty;
        Url = new ResourceUrl();
    }
    
    public Recommendation(string title, string description, ResourceUrl url)
    {
        Title = title;
        Description = description;
        Url = url;
    }
}