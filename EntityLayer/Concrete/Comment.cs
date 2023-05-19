using System.ComponentModel.DataAnnotations;

namespace BlogApp.EntityLayer.Concrete;

public class Comment
{
    [Key]
    public int ID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string ThumbnailImage { get; set; }
    public string Image { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
    public Blog Blog { get; set; }
}