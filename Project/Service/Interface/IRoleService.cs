using Microsoft.AspNetCore.Identity;
using MyProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IRoleService
    {
        IEnumerable<IdentityRole> GetAllRole(Func<IQueryable<IdentityRole>, IQueryable<IdentityRole>> filterFull = null, Expression<Func<IdentityRole, bool>> filter = null, Func<IQueryable<IdentityRole>, IOrderedQueryable<IdentityRole>> orderBy = null, string includeProperties = "");
    }
}
