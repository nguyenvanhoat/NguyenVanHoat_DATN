using AutoMapper;
using Microsoft.Extensions.FileProviders;
using MyProject.Data.Entities;
using MyProject.ViewModel;
using Service.File;
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
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _file;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper, IFileService file)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _file = file;
        }
        public void DeleteProduct(ProductDTO model)
        {
            _unitOfWork.GenericRepository<Product>().Delete(_mapper.Map<Product>(model));
            _unitOfWork.Save();
        }
        
        public void DeleteProductById(int id)
        {
            _unitOfWork.GenericRepository<Product>().DeleteById(id);
            _unitOfWork.Save();
        }

        public void DeleteProductStatus(int id)
        {
            var product = GetProductById(id);
            product.DeleteAt = DateTime.Now;
            _unitOfWork.GenericRepository<Product>().Update(_mapper.Map<Product>(product));
            _unitOfWork.Save();
        }

        public PagedResult<ProductDTO> GetAllProduct(int pageNumber, int pageSize, Func<IQueryable<Product>, IQueryable<Product>> filterFull = null, Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<ProductDTO> vmList = new List<ProductDTO>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                var modelList = _unitOfWork.GenericRepository<Product>().GetAll(filterFull, filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<Product>().GetAll(filterFull, filter, orderBy, includeProperties).ToList().Count();
                vmList = ConvertModelToModelViewList(modelList);
            }
            catch (Exception)
            {
                throw;
            }

            return new PagedResult<ProductDTO>(vmList, totalCount, pageNumber, pageSize);
        }

        public IEnumerable<ProductDTO> GetProduct(Func<IQueryable<Product>, IQueryable<Product>> filterFull = null, Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<Product>)_unitOfWork.GenericRepository<Product>().GetAll(filterFull, filter, orderBy, includeProperties));
        }

        public ProductDTO GetProductById(int id)
        {
            return _mapper.Map<ProductDTO>(_unitOfWork.GenericRepository<Product>().GetById(id));
        }

        public IEnumerable<ProductDTO> GetTopTenProduct(int size)
        {
            var modelList = _unitOfWork.GenericRepository<Product>().GetAll(null, filter: p => p.Trending == true,orderBy: p => p.OrderByDescending(x => x.Views) ,includeProperties: "Shop").Skip(0).Take(size).ToList();
            return ConvertModelToModelViewList(modelList);
        }

        public IEnumerable<ProductDTO> GetTrendingProduct(int size)
        {
            var modelList = _unitOfWork.GenericRepository<Product>().GetAll(null, filter: p=>p.Trending == true,  includeProperties: "Shop").Skip(0).Take(size).ToList();
            return ConvertModelToModelViewList(modelList);
        }

        public int InsertProduct(ProductDTO product)
        {
            var model = _mapper.Map<Product>(product);
            model.Thumbnail = _file.UpLoadFile(product.File);
            _unitOfWork.GenericRepository<Product>().Insert(model);
            _unitOfWork.Save();
            return model.Id;
        }

        public void UpDateProduct(ProductDTO product)
        {
            _unitOfWork.GenericRepository<Product>().Update(_mapper.Map<Product>(product));
            _unitOfWork.Save();
        }
        private List<ProductDTO> ConvertModelToModelViewList(List<Product> list)
        {
            return list.Select(x => _mapper.Map<ProductDTO>(x)).ToList();
        }
    }
}
