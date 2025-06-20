using Youper.API.Patient.Domain.Model.ValueObjects;

namespace Youper.API.Patient.Domain.Model.Entities;

public class Video
{
    public int Id { get; set; }
    public string Title { get; private set; }
    public ResourceUrl Url { get; private set; }

    public Video()
    {
        Title = string.Empty;
        Url = new ResourceUrl();
    }
    
    public Video(string title, ResourceUrl url)
    {
        Title = title;
        Url = url;
    }
}