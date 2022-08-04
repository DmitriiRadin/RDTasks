namespace RDTasks.Domain.Entities;

public class RDTask
{
    public int Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
    
    public DateTime? Deadline { get; set; }

    public IEnumerable<Comment> Comments { get; set; }
    public IEnumerable<Tag> Tags { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    public int ProjectId { get; set; }
    public Project Project { get; set; }
}