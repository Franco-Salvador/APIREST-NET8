using System.Data;
using System.Security.Principal;
using EjemploApiRest.Abstractions;
namespace EjemploApiRest.DataAccess

{
    public class DbContext<T> : IDbContext<T> where T : IEntity
    {
        IList<T> _data; //Lista para poder guardar los datos
        public DbContext()
        {
            _data = new List<T>();
        }
        public void Delete(int id)
        {
            var e = _data.Where(u => u.Id.Equals(id)).FirstOrDefault();
            if (e != null)
            {
                _data.Remove(e);
            }
        }

        public System.Collections.Generic.IList<T> GetAll()
        {
            return _data;
        }

        public T GetById(int id)
        {
            return _data.Where(e => e.Id.Equals(id)).FirstOrDefault();
        }

        public T Save(T entity)
        {
            if (entity.Id.Equals(0))
            {
                _data.Add(entity);

            }
            else
            {

            }

            return entity;
        }

    }
}