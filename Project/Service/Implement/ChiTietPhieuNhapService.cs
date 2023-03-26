using MyProject.Data.Entities;
using Service.Interface;
using Service.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implement
{
    public class ChiTietPhieuNhapService : IChiTietPhieuNhapService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ChiTietPhieuNhapService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void InsertChiTietPhieuNhap(ChiTietPhieuNhap ChiTietPhieuNhap)
        {
            _unitOfWork.GenericRepository<ChiTietPhieuNhap>().Insert(ChiTietPhieuNhap);
            _unitOfWork.Save();
        }
    }
}
