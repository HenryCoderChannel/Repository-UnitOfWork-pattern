using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryBase
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll(bool isTrackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool isTrackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
