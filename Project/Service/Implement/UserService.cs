using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MyProject.Data.Entities;
using MyProject.ViewModel;
using Service.Interface;
using Service.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implement
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }
        public void DeleteUser(UserDTO user)
        {
            _unitOfWork.GenericRepository<AppUser>().Delete(_mapper.Map<AppUser>(user));
            _unitOfWork.Save();
        }

        public void DeleteUserById(string id)
        {
            _unitOfWork.GenericRepository<AppUser>().DeleteById(id);
            _unitOfWork.Save();
        }

        public PagedResult<UserDTO> GetAllUser(int pageNumber, int pageSize, Func<IQueryable<AppUser>, IQueryable<AppUser>> filterFull = null, Expression<Func<AppUser, bool>> filter = null, Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> orderBy = null, string includeProperties = "")
        {
            //Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> sortOrder = user => user.OrderBy(p => p.CreateAt);
            int totalCount;
            List<UserDTO> vmList = new List<UserDTO>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                var modelList = _unitOfWork.GenericRepository<AppUser>().GetAll(filterFull ,filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<AppUser>().GetAll(filterFull ,filter, orderBy, includeProperties).ToList().Count();
                vmList = ConvertModelToModelViewList(modelList);
            }
            catch (Exception)
            {
                throw;
            }

            return new PagedResult<UserDTO>(vmList, totalCount, pageNumber, pageSize);

        }

        public IEnumerable<UserDTO> GetUser(Func<IQueryable<AppUser>, IQueryable<AppUser>> filterFull = null, Expression<Func<AppUser, bool>> filter = null, Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<AppUser>)_unitOfWork.GenericRepository<AppUser>().GetAll(filterFull, filter, orderBy, includeProperties));
        }

        public UserDTO GetUserById(string id)
        {
            return _mapper.Map<UserDTO>(_unitOfWork.GenericRepository<AppUser>().GetById(id));
        }

        public void InsertUser(UserDTO user)
        {
            _unitOfWork.GenericRepository<AppUser>().Insert(_mapper.Map<AppUser>(user));
            _unitOfWork.Save();
        }

        public async Task UpDateUser(UserDTO user)
        {
            //_unitOfWork.GenericRepository<AppUser>().Update(_mapper.Map<AppUser>(user));
            //_unitOfWork.Save();
            await _userManager.UpdateAsync(_mapper.Map<AppUser>(user));
        }

        private List<UserDTO> ConvertModelToModelViewList(List<AppUser> list)
        {
            return list.Select(x => _mapper.Map<UserDTO>(x)).ToList();
        }
    }
}
