using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class TourGuideImagesRelService : ITourGuideImagesRelService
    {
        public TblTourGuideImagesRel AddTourGuideImagesRel(TblTourGuideImagesRel tourGuideImagesRel)
        {
            return (TblTourGuideImagesRel)new TourGuideImagesRelRepo().AddTourGuideImagesRel(tourGuideImagesRel);
        }

        public bool DeleteTourGuideImagesRel(int id)
        {
            return new TourGuideImagesRelRepo().DeleteTourGuideImagesRel(id);
        }

        public bool UpdateTourGuideImagesRel(TblTourGuideImagesRel tourGuideImagesRel, int logId)
        {
            return new TourGuideImagesRelRepo().UpdateTourGuideImagesRel(tourGuideImagesRel, logId);
        }

        public List<TblTourGuideImagesRel> SelectAllTourGuideImagesRels()
        {
            return new TourGuideImagesRelRepo().SelectAllTourGuideImagesRels();
        }

        public TblTourGuideImagesRel SelectTourGuideImagesRelById(int id)
        {
            return new TourGuideImagesRelRepo().SelectTourGuideImagesRelById(id);
        }

        public List<TblTourGuideImagesRel> SelectTourGuideImagesRelByImageId(int imageId)
        {
            return new TourGuideImagesRelRepo().SelectTourGuideImagesRelByImageId(imageId);
        }

        public List<TblTourGuideImagesRel> SelectTourGuideImagesRelByTourGuideId(int tourGuideId)
        {
            return new TourGuideImagesRelRepo().SelectTourGuideImagesRelByTourGuideId(tourGuideId);
        }
    }
}