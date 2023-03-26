using Microsoft.EntityFrameworkCore;
using MyProject.Data.EF;
using Service.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository.Implement
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IGenericRepository<T> GenericRepository<T>() where T : class
        {
            return new GenericRepository<T>(_dbContext);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
