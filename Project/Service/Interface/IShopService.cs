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
    public interface IShopService
    {
        PagedResult<ShopDTO> GetAllShop(int pageNumber, int pageSize, Func<IQueryable<Shop>, IQueryable<Shop>> filterFull = null, Expression<Func<Shop, bool>> filter = null, Func<IQueryable<Shop>, IOrderedQueryable<Shop>> orderBy = null, string includeProperties = "");
        IEnumerable<ShopDTO> GetShop(Func<IQueryable<Shop>, IQueryable<Shop>> filterFull = null, Expression<Func<Shop, bool>> filter = null, Func<IQueryable<Shop>, IOrderedQueryable<Shop>> orderBy = null, string includeProperties = "");
        ShopDTO GetShopById(int id);
        void UpDateShop(ShopDTO model);
        void InsertShop(ShopDTO model);
        void DeleteShop(ShopDTO model);
        void DeleteShopById(int id);
        void DeleteShopStatus(int id);  
    }
}
