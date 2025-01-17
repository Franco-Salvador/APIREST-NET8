using EjemploApiRest.Abstractions;

namespace EjemploApiRest.Repository
{
    public interface IRepository<T> : ICrud<T>
    {
    }
    public class Repository<T> : IRepository<T>
    {
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IList<T> GetAll()
        {
            throw new System.NotImplementedException();
        }
        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }
        public T Save(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
