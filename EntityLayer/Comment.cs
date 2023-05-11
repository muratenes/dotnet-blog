namespace BlogApp.EntityLayer;

public class Comment
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string ThumbnailImage { get; set; }
    public string Image { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}