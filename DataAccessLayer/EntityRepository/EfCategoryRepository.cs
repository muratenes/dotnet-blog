using BlogApp.DataAccessLayer.Abstract;
using BlogApp.DataAccessLayer.Repositories;
using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.EntityRepository;

public class EfCategoryRepository : EfBaseRepository<Category>, ICategoryDal
{
    
}