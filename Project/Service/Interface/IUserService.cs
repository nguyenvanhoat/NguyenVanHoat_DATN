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
    public interface IUserService
    {
        PagedResult<UserDTO> GetAllUser(int pageNumber, int pageSize, Func<IQueryable<AppUser>, IQueryable<AppUser>> filterFull = null, Expression<Func<AppUser, bool>> filter = null, Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> orderBy = null, string includeProperties = "");
        IEnumerable<UserDTO> GetUser(Func<IQueryable<AppUser>, IQueryable<AppUser>> filterFull = null, Expression<Func<AppUser, bool>> filter = null, Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> orderBy = null, string includeProperties = "");
        UserDTO GetUserById(string id);
        Task UpDateUser(UserDTO user);
        void InsertUser(UserDTO user);
        void DeleteUser(UserDTO user);
        void DeleteUserById(string id);
    }
}
