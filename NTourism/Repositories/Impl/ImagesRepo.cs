using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class ImagesRepo: IImagesRepo
    {
        public TblImages AddImage(TblImages image)
        {
            return (TblImages)new MainProvider().Add(image);
        }

        public bool DeleteImage(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblImages, id);
        }

        public bool UpdateImage(TblImages image, int logId)
        {
            return new MainProvider().Update(image, logId);
        }

        public List<TblImages> SelectAllImages()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblImages).Cast<TblImages>().ToList();
        }

        public TblImages SelectImageById(int id)
        {
            return (TblImages)new MainProvider().SelectById(MainProvider.Tables.TblImages, id);
        }

        public List<TblImages> SelectImagesByName(string name)
        {
            return new MainProvider().SelectImagesByName(name);
        }
    }
}