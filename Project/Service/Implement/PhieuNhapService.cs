using AutoMapper;
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
    public class PhieuNhapService : IPhieuNhapService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PhieuNhapService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void DeletePhieuNhap(PhieuNhap PhieuNhap)
        {
            _unitOfWork.GenericRepository<PhieuNhap>().Delete(PhieuNhap);
            _unitOfWork.Save();
        }

        public void DeletePhieuNhapById(int id)
        {
            _unitOfWork.GenericRepository<PhieuNhap>().DeleteById(id);
        }

        public PagedResult<PhieuNhap> GetAllPhieuNhap(int pageNumber, int pageSize, Func<IQueryable<PhieuNhap>, IQueryable<PhieuNhap>> filterFull = null, Expression<Func<PhieuNhap, bool>> filter = null, Func<IQueryable<PhieuNhap>, IOrderedQueryable<PhieuNhap>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<PhieuNhap> vmList = new List<PhieuNhap>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                vmList = _unitOfWork.GenericRepository<PhieuNhap>().GetAll(filterFull, filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<PhieuNhap>().GetAll(filterFull, filter, orderBy, includeProperties).ToList().Count();

            }
            catch (Exception)
            {
                throw;
            }

            return new PagedResult<PhieuNhap>(vmList, totalCount, pageNumber, pageSize);
        }

        public IEnumerable<PhieuNhap> GetPhieuNhap(Func<IQueryable<PhieuNhap>, IQueryable<PhieuNhap>> filterFull = null, Expression<Func<PhieuNhap, bool>> filter = null, Func<IQueryable<PhieuNhap>, IOrderedQueryable<PhieuNhap>> orderBy = null, string includeProperties = "")
        {
            return _unitOfWork.GenericRepository<PhieuNhap>().GetAll(filterFull, filter, orderBy, includeProperties);
        }

        public PhieuNhap GetPhieuNhapById(int id)
        {
            return _unitOfWork.GenericRepository<PhieuNhap>().GetById(id);
        }

        public void InsertPhieuNhap(PhieuNhap PhieuNhap)
        {
            throw new NotImplementedException();
        }

        public void UpDatePhieuNhap(PhieuNhap PhieuNhap)
        {
            throw new NotImplementedException();
        }
    }
}
