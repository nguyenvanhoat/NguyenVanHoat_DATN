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
    public interface IReviewsAndWishListService
    {
        PagedResult<ReviewsDTO> GetAllReviews(int pageNumber, int pageSize, Func<IQueryable<Reviews>, IQueryable<Reviews>> filterFull = null, Expression<Func<Reviews, bool>> filter = null, Func<IQueryable<Reviews>, IOrderedQueryable<Reviews>> orderBy = null, string includeProperties = "");
        void RemoveWishList(string userId, int productId);
        void AddWishList(string userId, int productId);
        ReviewsDTO GetReviewById(string userId, int productId);
        void UpDateReview(ReviewsDTO review);
        IEnumerable<ReviewsDTO> GetReview(Func<IQueryable<Reviews>, IQueryable<Reviews>> filterFull = null, Expression<Func<Reviews, bool>> filter = null, Func<IQueryable<Reviews>, IOrderedQueryable<Reviews>> orderBy = null, string includeProperties = "");
        bool IsWishList(string userId, int productId);
        void Viewed(string userId, int productId);
        void Delete(string userId, int productId);
        IEnumerable<ReviewsDTO> GetProductViewd(int size, string userId);
    }
}
