using BlogApp.DataAccessLayer.Abstract;
using BlogApp.DataAccessLayer.Repositories;
using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.EntityRepository;

public class EfBaseRepository<T> : GenericRepository<T> where T : class
{
}