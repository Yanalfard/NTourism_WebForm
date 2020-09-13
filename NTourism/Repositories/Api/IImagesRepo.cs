using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IImagesRepo
    {
        TblImages AddImage(TblImages image);
        bool DeleteImage(int id);
        bool UpdateImage(TblImages image, int logId);
        List<TblImages> SelectAllImages();
        TblImages SelectImageById(int id);
        List<TblImages> SelectImagesByName(string name);

    }
}