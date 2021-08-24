using AllNews.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly AllNewsDbContext _context;
        private DbSet<TEntity> _entity;
        public Repository(AllNewsDbContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }
        

        public IEnumerable<TEntity> GetAll()
            => _entity.ToList();



        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
            => _entity.Where(expression);
        public TEntity Get(Expression<Func<TEntity, bool>> expression)
            => _entity.FirstOrDefault(expression);


        public void Add(TEntity entity)
        {
             _entity.Add(entity);          
        }
        public void Update(TEntity entity)
        {
            _entity.Update(entity);            
        }
        public void Delete(TEntity entity)
        {
            _entity.Remove(entity);           
        }

        public void AddRange(List<TEntity> entities)
        {
            _entity.AddRange(entities);
        }

        public bool Any(Expression<Func<TEntity, bool>> expression= null)
            => _entity.Where(expression).Any();
    }
}
