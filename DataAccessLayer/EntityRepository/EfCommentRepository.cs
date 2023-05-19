using BlogApp.DataAccessLayer.Abstract;
using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.EntityRepository;

public class EfCommentRepository : EfBaseRepository<Comment>, ICommentDal
{
    
}