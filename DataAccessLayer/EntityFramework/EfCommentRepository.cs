using BlogApp.DataAccessLayer.Abstract;
using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.EntityFramework;

public class EfCommentRepository : EfBaseRepository<Comment>, ICommentDal
{
    
}