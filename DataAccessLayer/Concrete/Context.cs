using BlogApp.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;


namespace BlogApp.DataAccessLayer.Concrete;

public class Context : DbContext
{
    static readonly string connectionString = "Server=localhost; User ID=root; Password=141277kk; Database=core_blog";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Writer> Writers { get; set; }
}