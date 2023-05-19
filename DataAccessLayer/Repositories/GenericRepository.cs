using BlogApp.DataAccessLayer.Abstract;
using BlogApp.DataAccessLayer.Concrete;

namespace BlogApp.DataAccessLayer.Repositories;

public class GenericRepository<T> : IGenericDal<T> where T : class
{
    private Context _context = new Context();
    
    public void Insert(T t)
    {
        _context.Add(t);
        _context.SaveChanges();
    }

    public void Delete(T t)
    {
        _context.Remove(t);
        _context.SaveChanges();
    }

    public void Update(T t)
    {
        _context.Update(t);
        _context.SaveChanges();
    }

    public List<T> All()
    {
        return _context.Set<T>().ToList();
    }

    public T Find(int id)
    {
        return _context.Set<T>().Find(id);
    }
}