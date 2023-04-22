using MyProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IDatLichService
    {
        PagedResult<DatLich> GetAllDatLich(int pageNumber, int pageSize, Func<IQueryable<DatLich>, IQueryable<DatLich>> filterFull = null, Expression<Func<DatLich, bool>> filter = null, Func<IQueryable<DatLich>, IOrderedQueryable<DatLich>> orderBy = null, string includeProperties = "");
    }
}
