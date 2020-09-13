using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class TourGuideResumeRelService : ITourGuideResumeRelService
    {
        public TblTourGuideResumeRel AddTourGuideResumeRel(TblTourGuideResumeRel tourGuideResumeRel)
        {
            return (TblTourGuideResumeRel)new TourGuideResumeRelRepo().AddTourGuideResumeRel(tourGuideResumeRel);
        }

        public bool DeleteTourGuideResumeRel(int id)
        {
            return new TourGuideResumeRelRepo().DeleteTourGuideResumeRel(id);
        }

        public bool UpdateTourGuideResumeRel(TblTourGuideResumeRel tourGuideResumeRel, int logId)
        {
            return new TourGuideResumeRelRepo().UpdateTourGuideResumeRel(tourGuideResumeRel, logId);
        }

        public List<TblTourGuideResumeRel> SelectAllTourGuideResumeRels()
        {
            return new TourGuideResumeRelRepo().SelectAllTourGuideResumeRels();
        }

        public TblTourGuideResumeRel SelectTourGuideResumeRelById(int id)
        {
            return new TourGuideResumeRelRepo().SelectTourGuideResumeRelById(id);
        }

        public List<TblTourGuideResumeRel> SelectTourGuideResumeRelByResumeId(int resumeId)
        {
            return new TourGuideResumeRelRepo().SelectTourGuideResumeRelByResumeId(resumeId);
        }

        public List<TblTourGuideResumeRel> SelectTourGuideResumeRelByTourGuideId(int tourGuideId)
        {
            return new TourGuideResumeRelRepo().SelectTourGuideResumeRelByTourGuideId(tourGuideId);
        }
    }
}