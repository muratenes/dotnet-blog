using BlogApp.DataAccessLayer.Abstract;
using BlogApp.DataAccessLayer.Concrete;
using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.Repositories;

public class BlogRepository : IBLogDal
{
    public List<Blog> All()
    {
        using var c = new Context();
        return c.Blogs.ToList();
    }

    public void Create(Blog blog)
    {
        using var c = new Context();
        c.Add(blog);
        c.SaveChanges();
    }

    public void Update(Blog blog)
    {
        using var c = new Context();
        c.Update(blog);
        c.SaveChanges();
    }

    public void Delete(Blog blog)
    {
        using var c = new Context();
        c.Remove(blog);
        c.SaveChanges();
    }

    public Blog Find(int id)
    {
        using var c = new Context();
        return c.Blogs.Find(id);
    }
}