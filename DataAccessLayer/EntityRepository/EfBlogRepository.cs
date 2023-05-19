using BlogApp.DataAccessLayer.Abstract;
using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.EntityRepository;

public class EfBlogRepository : EfBaseRepository<Blog>, IBlogDal
{
    
}