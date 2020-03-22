using CleanArchitecture.SharedKernel;
using CleanArchitecture.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data
{
    public class EfRepository : IRepository
    {
        private readonly DbContext _dbContext;

        public EfRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T Add<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public void Delete<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<T> Get<T>(Expression<Func<T, bool>> condition) where T : class
        {
            return _dbContext.Set<T>().Where(condition).ToList();
        }

        public List<T> GetAll<T>() where T : class
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetSingle<T>(Expression<Func<T, bool>> condition) where T : class
        {
            return _dbContext.Set<T>().SingleOrDefault(condition);
        }

        public void Update<T>(T entity) where T : class
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
