using BlogApp.DataAccessLayer.Abstract;
using BlogApp.DataAccessLayer.Concrete;
using BlogApp.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DataAccessLayer.EntityFramework;

public class EfBlogRepository : EfBaseRepository<Blog>, IBlogDal
{
    public List<Blog> GetWithCategories()
    {
        using (var context = new Context())
        {
            return context.Blogs.Include(x => x.Category).ToList();
        }
    }
}