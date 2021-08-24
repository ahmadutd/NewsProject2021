using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> GetAll();
   
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        TEntity Get(Expression<Func<TEntity, bool>> expression);


        void Add(TEntity entity);
        void AddRange(List<TEntity> entities);
        void Update(TEntity entity);
        void Delete(TEntity entity);


        bool Any(Expression<Func<TEntity, bool>> expression = null);
        
    }
}
