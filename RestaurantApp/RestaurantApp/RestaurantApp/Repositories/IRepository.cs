using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RestaurantApp.Repositories
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> FilterEntityByName(Expression<Func<TEntity, string>> predicate);
        TEntity Insert(TEntity model);
        void Edit(TEntity model);
        void Remove(TEntity model);
    }
}
