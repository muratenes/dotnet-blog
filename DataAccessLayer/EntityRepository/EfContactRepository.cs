using BlogApp.DataAccessLayer.Abstract;
using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.EntityRepository;

public class EfContactRepository : EfBaseRepository<Contact>, IContactDal
{
    
}