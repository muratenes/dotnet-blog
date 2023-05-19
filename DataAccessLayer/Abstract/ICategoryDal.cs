using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.Abstract;

public interface ICategoryDal
{
    List<Category> All();
    Category Create(Category category);
    void Update(Category category);
    void Delete(Category category);
    Category Find(int id);
}