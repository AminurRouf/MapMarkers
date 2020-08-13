using System;
using System.Collections.Generic;
using System.Linq;
using IRISMap.DbContext;
using IRISMap.Interfaces;

namespace IRISMap.Repositories
{
    public class XmlRepository<T> : IRepository<T> where T : Entity
    {
        protected IList<T> ContextEntities => _entities ?? (_entities = _dbContext.DbSet<T>());
        private readonly XmlContext _dbContext;
        private IList<T> _entities;

        public XmlRepository(XmlContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Entities => ContextEntities.AsQueryable();

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

      
    } 

}