using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RestaurantApp.Repositories
{
    public abstract class GenericRepository<GenericRepositoryContext, TEntity> : IRepository<TEntity> where GenericRepositoryContext : DbContext, new() where TEntity : class
    {
        private static  GenericRepositoryContext _context = new GenericRepositoryContext();

        public GenericRepositoryContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }
       public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            var isEntityFound = _context.Set<TEntity>().Where(predicate);
            return isEntityFound.ToList();
        }
        public virtual TEntity Insert(TEntity model)
        {
           var insertResult = _context.Set<TEntity>().Add(model);
           return insertResult;
        }
        public virtual void Edit(TEntity model)
        {
            _context.Set<TEntity>().Attach(model);
            _context.Entry(model).State = EntityState.Modified;
        }
        public virtual void Remove(TEntity model)
        {
            _context.Set<TEntity>().Remove(model);
        }
        public int saveChanges()
        {
            return _context.SaveChanges();
        }

        public IEnumerable<TEntity> FilterEntityByName(Expression<Func<TEntity, string>> predicate)
        {
            return _context.Set<TEntity>().OrderBy(predicate).ToList();
        }
    }
}
