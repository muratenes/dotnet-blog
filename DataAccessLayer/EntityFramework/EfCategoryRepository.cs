using BlogApp.DataAccessLayer.Abstract;
using BlogApp.DataAccessLayer.Repositories;
using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.EntityFramework;

public class EfCategoryRepository : EfBaseRepository<Category>, ICategoryDal
{
    
}