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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderDetailService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

        public void Create(OrderDetailDTO orderDetailDTO)
        {

            var model = _mapper.Map<OrderDetail>(orderDetailDTO);
            _unitOfWork.GenericRepository<OrderDetail>().Insert(model);
            _unitOfWork.Save();
        }
    }
}
