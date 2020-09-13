using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class TourGuideImagesRelRepo: ITourGuideImagesRelRepo
    {
        public TblTourGuideImagesRel AddTourGuideImagesRel(TblTourGuideImagesRel tourGuideImagesRel)
        {
            return (TblTourGuideImagesRel)new MainProvider().Add(tourGuideImagesRel);
        }

        public bool DeleteTourGuideImagesRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblTourGuideImagesRel, id);
        }

        public bool UpdateTourGuideImagesRel(TblTourGuideImagesRel tourGuideImagesRel, int logId)
        {
            return new MainProvider().Update(tourGuideImagesRel, logId);
        }

        public List<TblTourGuideImagesRel> SelectAllTourGuideImagesRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblTourGuideImagesRel).Cast<TblTourGuideImagesRel>()
                .ToList();
        }

        public TblTourGuideImagesRel SelectTourGuideImagesRelById(int id)
        {
            return (TblTourGuideImagesRel)new MainProvider().SelectById(MainProvider.Tables.TblTourGuideImagesRel, id);
        }

        public List<TblTourGuideImagesRel> SelectTourGuideImagesRelByImageId(int imagesId)
        {
            return new MainProvider().SelectTourGuideImagesRel(imagesId, MainProvider.TourGuideImagesRel.ImageId);
        }

        public List<TblTourGuideImagesRel> SelectTourGuideImagesRelByTourGuideId(int tourGuideId)
        {
            return new MainProvider().SelectTourGuideImagesRel(tourGuideId,
                MainProvider.TourGuideImagesRel.TourGuideId);
        }
    }
}