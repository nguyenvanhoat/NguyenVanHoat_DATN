using MyProject.Data.Entities;
using MyProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IOrderService
    {
        PagedResult<Order> GetAllOrder(int pageNumber, int pageSize, Func<IQueryable<Order>, IQueryable<Order>> filterFull = null, Expression<Func<Order, bool>> filter = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, string includeProperties = "");
        IEnumerable<Order> GetOrder(Func<IQueryable<Order>, IQueryable<Order>> filterFull = null, Expression<Func<Order, bool>> filter = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, string includeProperties = "");
        Order GetOrderById(int id);
        void UpDateOrder(Order Order);
        void InsertOrder(Order Order);
        void DeleteOrder(Order Order);
        void DeleteOrderById(int id);
        int Create(OrderDTO order);
    }
}
