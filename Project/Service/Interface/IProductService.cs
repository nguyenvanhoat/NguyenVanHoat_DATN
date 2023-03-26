using Microsoft.AspNetCore.Identity;
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
    public interface IProductService
    {
        PagedResult<ProductDTO> GetAllProduct(int pageNumber, int pageSize, Func<IQueryable<Product>, IQueryable<Product>> filterFull = null, Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, string includeProperties = "");
        IEnumerable<ProductDTO> GetProduct(Func<IQueryable<Product>, IQueryable<Product>> filterFull = null, Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, string includeProperties = "");
        ProductDTO GetProductById(int id);
        void UpDateProduct(ProductDTO product);
        int InsertProduct(ProductDTO product);
        void DeleteProduct(ProductDTO product);
        void DeleteProductById(int id);
        void DeleteProductStatus(int id);
        IEnumerable<ProductDTO> GetTrendingProduct(int size);
        IEnumerable<ProductDTO> GetTopTenProduct(int size);
    }
}
