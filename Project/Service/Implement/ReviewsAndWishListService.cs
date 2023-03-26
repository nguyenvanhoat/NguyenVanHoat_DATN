using AutoMapper;
using MyProject.Data.Entities;
using MyProject.ViewModel;
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
    public class ReviewsAndWishListService : IReviewsAndWishListService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ReviewsAndWishListService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void UpDateReview(ReviewsDTO review)
        {
            _unitOfWork.GenericRepository<Reviews>().Update(_mapper.Map<Reviews>(review));
            _unitOfWork.Save();
        }
        private bool CheckViewed(string userId, int productId)
        {
            var model = _unitOfWork.GenericRepository<Reviews>().GetAll(filterFull: null, filter: p => p.ProductId == productId && p.UserId == userId).FirstOrDefault();
            if(model == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public ReviewsDTO GetReviewById(string userId, int productId)
        {
           var model =  _unitOfWork.GenericRepository<Reviews>().GetAll(null, p => p.ProductId == productId && p.UserId == userId).FirstOrDefault();
            return _mapper.Map<ReviewsDTO>(model);
        }

        public void AddWishList(string userId, int productId)
        {
            var model = GetReviewById(userId, productId);
            if(model == null)
            {
                ReviewsDTO review = new ReviewsDTO
                {
                    UserId = userId,
                    ProductId = productId,
                    IsWishList = true
                };
                _unitOfWork.GenericRepository<Reviews>().Insert(_mapper.Map<Reviews>(review));
                _unitOfWork.Save();
            }
            else
            {
                model.IsWishList = true;
                UpDateReview(model);
            }
        }

        public void RemoveWishList(string userId, int productId)
        {
            var model = GetReviewById(userId, productId);
            model.IsWishList = false;
            UpDateReview(model);
        }

        public bool IsWishList(string userId, int productId)
        {
            var model = GetReviewById(userId, productId);
            if(model == null)
            {
                return false;
            }
            else
            {
                return model.IsWishList;
            }
        }

        //public void AddWishList(string userId, int productId)
        //{
        //    var model = GetReviewById(userId, productId);
        //    if(model != null)
        //    {

        //    }
        //}

        public void Viewed(string userId, int productId)
        {
            var check = _unitOfWork.GenericRepository<Reviews>().GetAll(filterFull: null, filter: p => p.ProductId == productId && p.UserId == userId).FirstOrDefault();
            if (check == null)
            {
                var model = new ReviewsDTO()
                {
                    UserId = userId,
                    ProductId = productId,
                    Viewd = true,
                    DateView = DateTime.Now
                };
                Reviews review = _mapper.Map<Reviews>(model);
                _unitOfWork.GenericRepository<Reviews>().Insert(review);
                _unitOfWork.Save();
            }
            else
            {
                check.Viewd = true;
                UpDateReview(_mapper.Map<ReviewsDTO>(check));
            }
        }

        public IEnumerable<ReviewsDTO> GetReview(Func<IQueryable<Reviews>, IQueryable<Reviews>> filterFull = null, Expression<Func<Reviews, bool>> filter = null, Func<IQueryable<Reviews>, IOrderedQueryable<Reviews>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<Reviews>)_unitOfWork.GenericRepository<Reviews>().GetAll(filterFull, filter, orderBy, includeProperties));
        }

        private List<ReviewsDTO> ConvertModelToModelViewList(List<Reviews> list)
        {
            return list.Select(x => _mapper.Map<ReviewsDTO>(x)).ToList();
        }

        public PagedResult<ReviewsDTO> GetAllReviews(int pageNumber, int pageSize, Func<IQueryable<Reviews>, IQueryable<Reviews>> filterFull = null, Expression<Func<Reviews, bool>> filter = null, Func<IQueryable<Reviews>, IOrderedQueryable<Reviews>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<ReviewsDTO> vmList = new List<ReviewsDTO>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                var modelList = _unitOfWork.GenericRepository<Reviews>().GetAll(filterFull, filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<Reviews>().GetAll(filterFull, filter, orderBy, includeProperties).ToList().Count();
                vmList = ConvertModelToModelViewList(modelList);
            }
            catch (Exception)
            {
                throw;
            }

            return new PagedResult<ReviewsDTO>(vmList, totalCount, pageNumber, pageSize);
        }

        public void Delete(string userId, int productId)
        {
            var model = GetReviewById(userId, productId);
            model.DeleteAt = DateTime.Now;
            UpDateReview(model);
        }

        public IEnumerable<ReviewsDTO> GetProductViewd(int size, string userId)
        {
            var modelList = _unitOfWork.GenericRepository<Reviews>().GetAll(null, filter: p => p.UserId == userId, includeProperties: "Product").Skip(0).Take(size).ToList();
            return ConvertModelToModelViewList(modelList);
        }
    }
}
