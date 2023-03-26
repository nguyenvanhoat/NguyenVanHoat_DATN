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
    public interface IPhieuNhapService
    {
        PagedResult<PhieuNhap> GetAllPhieuNhap(int pageNumber, int pageSize, Func<IQueryable<PhieuNhap>, IQueryable<PhieuNhap>> filterFull = null, Expression<Func<PhieuNhap, bool>> filter = null, Func<IQueryable<PhieuNhap>, IOrderedQueryable<PhieuNhap>> orderBy = null, string includeProperties = "");
        IEnumerable<PhieuNhap> GetPhieuNhap(Func<IQueryable<PhieuNhap>, IQueryable<PhieuNhap>> filterFull = null, Expression<Func<PhieuNhap, bool>> filter = null, Func<IQueryable<PhieuNhap>, IOrderedQueryable<PhieuNhap>> orderBy = null, string includeProperties = "");
        PhieuNhap GetPhieuNhapById(int id);
        void UpDatePhieuNhap(PhieuNhap PhieuNhap);
        void InsertPhieuNhap(PhieuNhap PhieuNhap);
        void DeletePhieuNhap(PhieuNhap PhieuNhap);
        void DeletePhieuNhapById(int id);
    }
}
