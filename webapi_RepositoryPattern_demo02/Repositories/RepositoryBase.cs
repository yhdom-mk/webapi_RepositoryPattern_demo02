using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using webapi_RepositoryPattern_demo02.Contracts;

namespace webapi_RepositoryPattern_demo02.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationContext ApplicationContext;
        public RepositoryBase(ApplicationContext _applicationContext)
        {
            ApplicationContext = _applicationContext;
        }

        public IQueryable<T> GetAll(bool trackChanges)
        {
            return
                !trackChanges ?
                ApplicationContext.Set<T>().AsNoTracking() :
                ApplicationContext.Set<T>();
        }
        //{
        //    throw new NotImplementedException();
        //}
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        { 
            return
              !trackChanges ?
                ApplicationContext.Set<T>().Where(expression).AsNoTracking() :
                ApplicationContext.Set<T>().Where(expression);
            //throw new NotImplementedException();  
        }


        public void Create(T entity) =>
            ApplicationContext.Set<T>().Add(entity);
        //throw new NotImplementedException();
        public void Update(T entity) =>
            ApplicationContext.Set<T>().Update(entity);
        //throw new NotImplementedException();
        public void Delete(T entity) =>
            ApplicationContext.Set<T>.Remove(entity);
            //throw new NotImplementedException();

        
    }
}
