namespace WebApi.Models;

public class UserStory
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int Estimate { get; set; }

    public UserStory(int Id, string Description, int Estimate)
    {
        this.Id = Id;
        this.Description = Description;
        this.Estimate = Estimate;
    }

    public UserStory()
    {
        
    }
}