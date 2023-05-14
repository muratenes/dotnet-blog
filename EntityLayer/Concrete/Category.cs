using System.ComponentModel.DataAnnotations;

namespace BlogApp.EntityLayer.Concrete;
public class Category
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
    public string Image { get; set; }
    public string ThumbnailImage { get; set; }
}