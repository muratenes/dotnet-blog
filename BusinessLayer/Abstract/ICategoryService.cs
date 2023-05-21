using BlogApp.EntityLayer.Concrete;

namespace BusinessLayer.Abstract;

public interface ICategoryService
{
    void Add(Category category); 
    void Delete(Category category); 
    void Update(Category category); 
    List<Category> List();
    Category Find(int id);
}