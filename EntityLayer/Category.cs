namespace BlogApp.EntityLayer;

public class Category
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
    public string Image { get; set; }
    public string ThumbnailImage { get; set; }
}