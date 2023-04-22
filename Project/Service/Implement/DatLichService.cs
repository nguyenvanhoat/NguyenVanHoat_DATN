using MyProject.Data.Entities;
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
    public class DatLichService : IDatLichService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DatLichService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public PagedResult<DatLich> GetAllDatLich(int pageNumber, int pageSize, Func<IQueryable<DatLich>, IQueryable<DatLich>> filterFull = null, Expression<Func<DatLich, bool>> filter = null, Func<IQueryable<DatLich>, IOrderedQueryable<DatLich>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<DatLich> vmList = new List<DatLich>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                vmList = _unitOfWork.GenericRepository<DatLich>().GetAll(filterFull, filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<DatLich>().GetAll(filterFull, filter, orderBy, includeProperties).ToList().Count();

            }
            catch (Exception)
            {
                throw;
            }

            return new PagedResult<DatLich>(vmList, totalCount, pageNumber, pageSize);
        }
    }
}
