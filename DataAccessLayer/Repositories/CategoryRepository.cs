using BlogApp.DataAccessLayer.Abstract;
using BlogApp.DataAccessLayer.Concrete;
using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.Repositories;

public class CategoryRepository : ICategoryDal
{
    private Context context = new Context();

    public List<Category> All()
    {
        return context.Categories.ToList();
    }

    public Category Create(Category category)
    {
        context.Add(category);
        context.SaveChanges();
        return category;
    }

    public void Update(Category category)
    {
        context.Update(category);
        context.SaveChanges();
    }

    public void Delete(Category category)
    {
        context.Remove(category);
        context.SaveChanges();
    }

    public Category Find(int id)
    {
       return context.Categories.Find(id);
    }
}