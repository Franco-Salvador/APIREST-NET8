﻿using System.Data;
using EjemploApiRest.Abstractions;
namespace EjemploApiRest.DataAccess
{
    public class DbContext<T> : IDbContext<T>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}