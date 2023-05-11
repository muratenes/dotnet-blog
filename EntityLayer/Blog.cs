namespace BlogApp.EntityLayer;

public class Blog
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}