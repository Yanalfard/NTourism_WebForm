using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class ImagesService : IImagesService
    {
        public TblImages AddImage(TblImages image)
        {
            return (TblImages)new ImagesRepo().AddImage(image);
        }

        public bool DeleteImage(int id)
        {
            return new ImagesRepo().DeleteImage(id);
        }

        public bool UpdateImage(TblImages image, int logId)
        {
            return new ImagesRepo().UpdateImage(image, logId);
        }

        public List<TblImages> SelectAllImages()
        {
            return new ImagesRepo().SelectAllImages();
        }

        public TblImages SelectImageById(int id)
        {
            return new ImagesRepo().SelectImageById(id);
        }

        public List<TblImages> SelectImagesByName(string name)
        {
            return new ImagesRepo().SelectImagesByName(name);
        }
    }
}