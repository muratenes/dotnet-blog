using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.Abstract;

public interface IBLogDal
{
    List<Blog> All();
    void Create(Blog category);
    void Update(Blog category);
    void Delete(Blog category);
    Blog Find(int id);
}