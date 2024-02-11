using WebApi.Service;

namespace WebApi.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Status { get; set; }
    public string Responsible { get; set; }
    
    public List<UserStory> userStories { get; set; }

    public Project(int Id, string Title, string Status, string Responsible, List<UserStory> userStories)
    {
        this.Id = Id;
        this.Title = Title;
        this.Status = Status;
        this.Responsible = Responsible;
        this.userStories = userStories;
    }
    public Project()
    {
        
    }
}