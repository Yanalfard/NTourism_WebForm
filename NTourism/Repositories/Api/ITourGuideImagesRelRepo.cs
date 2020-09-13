using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ITourGuideImagesRelRepo
    {
        TblTourGuideImagesRel AddTourGuideImagesRel(TblTourGuideImagesRel tourGuideImagesRel);
        bool DeleteTourGuideImagesRel(int id);
        bool UpdateTourGuideImagesRel(TblTourGuideImagesRel tourGuideImagesRel, int logId);
        List<TblTourGuideImagesRel> SelectAllTourGuideImagesRels();
        TblTourGuideImagesRel SelectTourGuideImagesRelById(int id);
        List<TblTourGuideImagesRel> SelectTourGuideImagesRelByImageId(int imageId);
        List<TblTourGuideImagesRel> SelectTourGuideImagesRelByTourGuideId(int tourGuideId);
    }
}