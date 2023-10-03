namespace InterfaceSegregation
{
    public interface IRepository<T>
    {
        T Get(int id);
        IList<T> GetAll();

        void Create(T entity);
        void Update(T entity);
        void Delete(int id);




    }

    public interface ISearchableByName<T>
    {
        IList<T> SearchByName(string name);
    }

    public class ProductRepository : IRepository<Product>, ISearchableByName<Product>
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Product> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }



    public class Comment
    {

    }

    public class CommentRepository : IRepository<Comment>
    {
        public void Create(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Comment> GetAll()
        {
            throw new NotImplementedException();
        }


        public void Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }


    public class SearchItemFromCollection
    {
        public IList<T> Search<T>(string name, ISearchableByName<T> searchProcess)
        {
            return searchProcess.SearchByName(name);
        }
    }
}
