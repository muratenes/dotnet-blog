using System.ComponentModel.DataAnnotations;

namespace BlogApp.EntityLayer.Concrete;

public class Contact
{
    [Key]
    public int ID { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}