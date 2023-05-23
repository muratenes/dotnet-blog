using BlogApp.DataAccessLayer.Abstract;
using BlogApp.EntityLayer.Concrete;
using BusinessLayer.Abstract;

namespace BlogApp.BusinessLayer.Concrete;

public class BlogManager : IBlogService
{
    private IBlogDal _blogDal;

    public BlogManager(IBlogDal blogDal)
    {
        _blogDal = blogDal;
    }


    public void Add(Blog blog)
    {
        _blogDal.Insert(blog);
    }

    public void Delete(Blog blog)
    {
        _blogDal.Delete(blog);
    }

    public void Update(Blog blog)
    {
        _blogDal.Update(blog);
    }

    public List<Blog> List()
    {
        return _blogDal.All();
    }

    public Blog Find(int id)
    {
        return _blogDal.Find(id);
    }

    public List<Blog> GetWithCategories()
    {
        return _blogDal.GetWithCategories();
    }
}