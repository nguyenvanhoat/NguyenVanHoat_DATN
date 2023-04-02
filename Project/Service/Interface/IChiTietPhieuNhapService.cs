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
    public interface IChiTietPhieuNhapService
    {
        void InsertChiTietPhieuNhap(ChiTietPhieuNhap ChiTietPhieuNhap);
        IEnumerable<ChiTietPhieuNhap> Get(Func<IQueryable<ChiTietPhieuNhap>, IQueryable<ChiTietPhieuNhap>> filterFull = null, Expression<Func<ChiTietPhieuNhap, bool>> filter = null, Func<IQueryable<ChiTietPhieuNhap>, IOrderedQueryable<ChiTietPhieuNhap>> orderBy = null, string includeProperties = "");
    }
}
