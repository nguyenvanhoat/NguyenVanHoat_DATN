using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MyProject.Data.Entities;
using MyProject.ViewModel;
using Service.File;
using Service.Interface;
using Service.Repository.Implement;
using Service.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Humanizer.On;

namespace Service.Implement
{
    public class MediasService : IMediasService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _file;
        private readonly IHostingEnvironment environment;
        private readonly IMapper _mapper;

        public MediasService(IUnitOfWork unitOfWork, IFileService file, IHostingEnvironment environment, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _file = file;
            this.environment = environment;
            _mapper = mapper;
        }
        public void DeleteMedias(MediasDTO medias)
        {
            var model = _unitOfWork.GenericRepository<Medias>().GetById(medias.Id);
            _unitOfWork.GenericRepository<Medias>().Delete(model);
            _unitOfWork.Save();
            _file.DeleteFile(medias.Name);
        }

        public void DeleteMediasById(int id)
        {
            var model = GetMediasById(id);
            DeleteMedias(model);
        }

        public IEnumerable<MediasDTO> GetMedias(Func<IQueryable<Medias>, IQueryable<Medias>> filterFull = null, Expression<Func<Medias, bool>> filter = null, Func<IQueryable<Medias>, IOrderedQueryable<Medias>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<Medias>)_unitOfWork.GenericRepository<Medias>().GetAll(filterFull, filter, orderBy, includeProperties));
        }

        public IEnumerable<MediasDTO> GetMediasByProductId(int id)
        {
            return ConvertModelToModelViewList((List<Medias>)_unitOfWork.GenericRepository<Medias>().GetAll(null, p => p.ProductId == id));
        }

        public MediasDTO GetMediasById(int id)
        {
            return _mapper.Map<MediasDTO>(_unitOfWork.GenericRepository<Medias>().GetById(id));
        }

        public void InsertMedias(MediasDTO model)
        {
            model.Name = _file.UpLoadFile(model.File);
            _unitOfWork.GenericRepository<Medias>().Insert(_mapper.Map<Medias>(model));
            _unitOfWork.Save();
        }

        public void UpDateMedias(MediasDTO medias)
        {
            var modelbyid = _unitOfWork.GenericRepository<Medias>().GetById(medias.Id);
            if (medias.File != null)
            {
                _file.DeleteFile(modelbyid.Name);
                modelbyid.Name = _file.UpLoadFile(medias.File);
            }
            _unitOfWork.GenericRepository<Medias>().Update(modelbyid);
            _unitOfWork.Save();
        }

        private List<MediasDTO> ConvertModelToModelViewList(List<Medias> list)
        {
            return list.Select(x => _mapper.Map<MediasDTO>(x)).ToList();
        }
    }
}
