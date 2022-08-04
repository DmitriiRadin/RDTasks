namespace RDTasks.Domain.Entities;

public class Tag
{
    public int Id { get; set; }

    public string Title { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}