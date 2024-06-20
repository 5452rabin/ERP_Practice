using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Practise.Data;
using Practise.GenericRepository.Interface;

namespace Practise.GenericRepository.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet=_dbContext.Set<T>();
        }
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            T entityToDelete = _dbSet.Find(id);
            if (entityToDelete != null)
            {
                _dbSet.Remove(entityToDelete);
                _dbContext.SaveChanges();
            }

        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            T entity = _dbSet.Find(id);
            return entity;
        }

        public T Update(T entity)
        {
           _dbSet.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
