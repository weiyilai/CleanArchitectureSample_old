using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CleanArchitecture.SharedKernel.Interfaces
{
    public interface IRepository
    {
        T GetSingle<T>(Expression<Func<T, bool>> condition) where T : class;

        List<T> GetAll<T>() where T : class;

        List<T> Get<T>(Expression<Func<T, bool>> condition) where T : class;

        T Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;
    }
}
