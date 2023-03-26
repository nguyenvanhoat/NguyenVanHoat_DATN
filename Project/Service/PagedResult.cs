using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PagedResult<T> where T : class
    {
        public List<T> Data { get; set; }
        public int TotalItem { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }

        public PagedResult()
        {

        }

        public PagedResult(List<T> Data, int totalItem, int pageNumber, int pageSize)
        {
            this.Data = Data;
            int totalPage = (int)Math.Ceiling((decimal)totalItem / (decimal)pageSize);

            int currentPage = pageNumber;

            int startPage = currentPage - 3;
            int endPage = currentPage + 2;

            if (startPage <= 0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }

            if (endPage > totalPage)
            {
                endPage = totalPage;
                if (endPage > 6)
                {
                    startPage = endPage - 5;
                }
            }

            TotalItem = totalItem;
            PageNumber = currentPage;
            PageSize = pageSize;
            TotalPages = totalPage;
            StartPage = startPage;
            EndPage = endPage;
        }
    }
}
