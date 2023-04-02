using AutoMapper;
using MyProject.Data.Entities;
using MyProject.ViewModel;
using Service.Interface;
using Service.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
