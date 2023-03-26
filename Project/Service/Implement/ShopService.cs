using AutoMapper;
using MyProject.Data.Entities;
using MyProject.ViewModel;
using Service.Interface;
using Service.Repository.Implement;
using Service.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implement
{
    public class ShopService : IShopService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ShopService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void DeleteShop(ShopDTO model)
        {
            var shop = _mapper.Map<Shop>(model);
            _unitOfWork.GenericRepository<Shop>().Delete(shop);
            _unitOfWork.Save();
        }

        public void DeleteShopById(int id)
        {
            _unitOfWork.GenericRepository<Shop>().DeleteById(id);
            _unitOfWork.Save();
        }

        public void DeleteShopStatus(int id)
        {
            //var shop = GetShopById(id);
            //shop.DeleteAt = DateTime.Now;
            ////_unitOfWork.GenericRepository<Shop>().Update(_mapper.Map<Shop>(shop));
            ////_unitOfWork.Save();
            //UpDateShop(shop);
            var model = GetShopById(id);
            var shop = _mapper.Map<Shop>(model);
            shop.DeleteAt = DateTime.Now; 
            _unitOfWork.GenericRepository<Shop>().Update(shop);
            _unitOfWork.Save();
        }

        public PagedResult<ShopDTO> GetAllShop(int pageNumber, int pageSize, Func<IQueryable<Shop>, IQueryable<Shop>> filterFull = null, Expression<Func<Shop, bool>> filter = null, Func<IQueryable<Shop>, IOrderedQueryable<Shop>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<ShopDTO> vmList = new List<ShopDTO>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                var modelList = _unitOfWork.GenericRepository<Shop>().GetAll(filterFull,filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<Shop>().GetAll(filterFull, filter, orderBy, includeProperties).ToList().Count();

                vmList = ConvertModelToModelViewList(modelList);
            }
            catch (Exception)
            {
                throw;
            }

            return new PagedResult<ShopDTO>(vmList, totalCount, pageNumber, pageSize);
        }

        public IEnumerable<ShopDTO> GetShop(Func<IQueryable<Shop>, IQueryable<Shop>> filterFull = null, Expression<Func<Shop, bool>> filter = null, Func<IQueryable<Shop>, IOrderedQueryable<Shop>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<Shop>)_unitOfWork.GenericRepository<Shop>().GetAll(filterFull, filter, orderBy, includeProperties));
        }

        public ShopDTO GetShopById(int id)
        {
            return _mapper.Map<ShopDTO>(_unitOfWork.GenericRepository<Shop>().GetById(id));
        }

        public void InsertShop(ShopDTO model)
        {
            var shop = _mapper.Map<Shop>(model);
            _unitOfWork.GenericRepository<Shop>().Insert(shop);
            _unitOfWork.Save();
        }

        public void UpDateShop(ShopDTO model)
        {
            var shop = _mapper.Map<Shop>(model);
            _unitOfWork.GenericRepository<Shop>().Update(shop);
            _unitOfWork.Save();
        }

        private List<ShopDTO> ConvertModelToModelViewList(List<Shop> list)
        {
            return list.Select(x => _mapper.Map<ShopDTO>(x)).ToList();
        }
    }
}
