using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.Abstract;

public interface IBlogDal : IGenericDal<Blog>
{
    List<Blog> GetWithCategories();
}