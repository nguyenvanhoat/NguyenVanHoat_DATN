using MyProject.Data.EF;
using System.Linq.Expressions;

namespace Service.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        public IEnumerable<T> GetAll(
            Func<IQueryable<T>, IQueryable<T>> filterFull = null,
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");
        public T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void DeleteById(object id); 
        void Delete(T entity);
    }
}