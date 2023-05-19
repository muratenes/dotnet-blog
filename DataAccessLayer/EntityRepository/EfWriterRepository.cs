using BlogApp.DataAccessLayer.Abstract;
using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.EntityRepository;

public class EfWriterRepository : EfBaseRepository<Writer>, IWriterDal
{
    
}