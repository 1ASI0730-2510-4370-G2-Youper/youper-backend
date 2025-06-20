using Youper.API.Patient.Domain.Model.ValueObjects;

namespace Youper.API.Patient.Domain.Model.Entities;

public class Music
{
    public int Id { get; set; }
    public string Title { get; private set; }
    public ResourceUrl Url { get; private set; }

    public Music()
    {
        Title = string.Empty;
        Url = new ResourceUrl();
    }
    
    public Music(string title, ResourceUrl url)
    {
        Title = title;
        Url = url;
    }
}