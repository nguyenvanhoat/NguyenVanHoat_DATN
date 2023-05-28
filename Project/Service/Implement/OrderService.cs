using AutoMapper;
using MyProject.Data.Entities;
using MyProject.ViewModel;
using Service.Interface;
using Service.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implement
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public int Create(OrderDTO order)
        {
            var model = _mapper.Map<Order>(order);
            _unitOfWork.GenericRepository<Order>().Insert(model);
            _unitOfWork.Save();
            return model.Id;
        }

        public void DeleteOrder(Order Order)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public PagedResult<Order> GetAllOrder(int pageNumber, int pageSize, Func<IQueryable<Order>, IQueryable<Order>> filterFull = null, Expression<Func<Order, bool>> filter = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<Order> vmList = new List<Order>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                vmList = _unitOfWork.GenericRepository<Order>().GetAll(filterFull, filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<Order>().GetAll(filterFull, filter, orderBy, includeProperties).ToList().Count();

            }
            catch (Exception)
            {
                throw;
            }

            return new PagedResult<Order>(vmList, totalCount, pageNumber, pageSize);
        }

        public IEnumerable<Order> GetOrder(Func<IQueryable<Order>, IQueryable<Order>> filterFull = null, Expression<Func<Order, bool>> filter = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertOrder(Order Order)
        {
            throw new NotImplementedException();
        }

        public void UpDateOrder(Order Order)
        {
            throw new NotImplementedException();
        }
    }
}
