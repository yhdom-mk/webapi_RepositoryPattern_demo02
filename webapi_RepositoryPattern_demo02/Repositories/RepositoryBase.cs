using System.Linq.Expressions;
using webapi_RepositoryPattern_demo02.Contracts;

namespace webapi_RepositoryPattern_demo02.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public IQueryable<T> GetAll(bool trackChanges)
        {
            return
                //!trackChanges ?
                //ApplicationContext.Set<T>().AsNoTracking() :
                //ApplicationContext.Set<T>();
        }
            
        //{
        //    throw new NotImplementedException();
        //}
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
