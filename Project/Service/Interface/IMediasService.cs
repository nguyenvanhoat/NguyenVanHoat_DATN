using Microsoft.AspNetCore.Http;
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
    public interface IMediasService
    {
        IEnumerable<MediasDTO> GetMedias(Func<IQueryable<Medias>, IQueryable<Medias>> filterFull = null, Expression<Func<Medias, bool>> filter = null, Func<IQueryable<Medias>, IOrderedQueryable<Medias>> orderBy = null, string includeProperties = "");
        IEnumerable<MediasDTO> GetMediasByProductId(int id);
        MediasDTO GetMediasById(int id);
        void UpDateMedias(MediasDTO medias);
        void InsertMedias(MediasDTO medias);
        void DeleteMedias(MediasDTO medias);
        void DeleteMediasById(int id);
    }
}
