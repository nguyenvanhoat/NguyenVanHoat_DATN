using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using MyProject.Data.Entities;
using Service.Repository.Implement;
using Service.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class TestUnitOfWork
    {
        private DependencyResolverHelper _serviceProvider;


        [TestMethod]
        public void Test()
        {
            // Arrange
            var services = new ServiceCollection();
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            var serviceProvider = services.BuildServiceProvider();

            var myService = serviceProvider.GetService<IUnitOfWork>();

            // Act
            var result = myService.GenericRepository<Order>().GetAll();

            if(result == null)
            {
                Assert.Fail();
            }

            // Assert
            //Assert.Equal("expected result", result);
        }
    }
}
