using AutoMapper;
using Moq;
using MyProject.Data.EF;
using MyProject.Data.Entities;
using MyProject.ViewModel;
using Service.Implement;
using Service.Interface;
using Service.Repository.Implement;
using Service.Repository.Interface;

namespace UnitTest
{
    [TestClass]
    public class TestShopService
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        IShopService _shopService;

        [TestInitialize]                
        public void Setup()
        {
            //_unitOfWork = new UnitOfWork(new AppDbContext());
        }

        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}