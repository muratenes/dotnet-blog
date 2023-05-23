using BlogApp.EntityLayer.Concrete;

namespace BusinessLayer.Abstract;

public interface IBlogService
{
    void Add(Blog blog); 
    void Delete(Blog blog); 
    void Update(Blog blog); 
    List<Blog> List();
    Blog Find(int id);
}