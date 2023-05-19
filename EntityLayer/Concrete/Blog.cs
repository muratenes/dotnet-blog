using System.ComponentModel.DataAnnotations;

namespace BlogApp.EntityLayer.Concrete;

public class Blog
{
    [Key]
    public int ID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public Category Category { get; set; }
}