using BlogApp.DataAccessLayer.Abstract;
using BlogApp.DataAccessLayer.EntityRepository;
using BlogApp.EntityLayer.Concrete;
using BusinessLayer.Abstract;

namespace BlogApp.BusinessLayer.Concrete;

public class CategoryManager : ICategoryService
{
    private ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }


    public void Add(Category category)
    {
        _categoryDal.Insert(category);
    }

    public void Delete(Category category)
    {
        _categoryDal.Delete(category);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }

    public List<Category> List(Category category)
    {
        return _categoryDal.All();
    }

    public Category Find(int id)
    {
        return _categoryDal.Find(id);
    }
}