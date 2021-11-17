﻿using EjemploApiRest.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EjemploApiRest.Repository
{
    public interface IRepository<T> : ICrud<T>
    {

    }
    public class Repository<T> : IRepository<T> where T : IEntity //Restriccion para que solo entren datos de la Interface
    {
        IDbContext<T> _context;
        public Repository(IDbContext<T> context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            _context.Delete(id);
        }

        public IList<T> GetAll()
        {
            return _context.GetAll();
        }

        public T GetById(int id)
        {
            return GetById(id);
        }

        public T Save(T entity)
        {
            return _context.Save(entity);
        }
    }


}
