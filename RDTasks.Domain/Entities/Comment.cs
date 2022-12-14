namespace RDTasks.Domain.Entities;

public class Comment
{
    public int Id { get; set; }

    public string Text { get; set; }
    public string CommentDate { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}