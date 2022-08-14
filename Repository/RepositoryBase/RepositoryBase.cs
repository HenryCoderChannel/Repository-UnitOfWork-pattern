using Entities.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryBase
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private TechCompanyContext _context;    //MUST be private

        public RepositoryBase(TechCompanyContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }


        /// <summary>
        /// 2 Methods: FindAll vs FindByCondition will return a DbSet for me to use
        /// I force to choose whether or not it will be tracked by EFCore
        /// </summary>
        /// <param name="isTrackChanges"></param>
        /// <returns></returns>
        public IQueryable<T> FindAll(bool isTrackChanges)
        {
            if (isTrackChanges)
                return _context.Set<T>();
            return _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool isTrackChanges)
        {
            if (isTrackChanges)
                return _context.Set<T>().Where(expression);
            return _context.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
