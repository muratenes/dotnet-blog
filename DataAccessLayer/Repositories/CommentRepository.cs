using BlogApp.DataAccessLayer.Abstract;
using BlogApp.EntityLayer.Concrete;

namespace BlogApp.DataAccessLayer.Repositories;

public class CommentRepository : IGenericDal<Comment>
{
    public void Insert(Comment t)
    {
        throw new NotImplementedException();
    }

    public void Delete(Comment t)
    {
        throw new NotImplementedException();
    }

    public void Update(Comment t)
    {
        throw new NotImplementedException();
    }

    public List<Comment> All()
    {
        throw new NotImplementedException();
    }

    public Comment Find(int id)
    {
        throw new NotImplementedException();
    }
}