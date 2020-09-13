using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class TourGuideResumeRelRepo : ITourGuideResumeRelRepo
    {
        public TblTourGuideResumeRel AddTourGuideResumeRel(TblTourGuideResumeRel tourGuideResumeRel)
        {
            return (TblTourGuideResumeRel)new MainProvider().Add(tourGuideResumeRel);
        }

        public bool DeleteTourGuideResumeRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblTourGuideResumeRel, id);
        }

        public bool UpdateTourGuideResumeRel(TblTourGuideResumeRel tourGuideResumeRel, int logId)
        {
            return new MainProvider().Update(tourGuideResumeRel, logId);
        }

        public List<TblTourGuideResumeRel> SelectAllTourGuideResumeRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblTourGuideResumeRel).Cast<TblTourGuideResumeRel>()
                .ToList();
        }

        public TblTourGuideResumeRel SelectTourGuideResumeRelById(int id)
        {
            return (TblTourGuideResumeRel)new MainProvider().SelectById(MainProvider.Tables.TblTourGuideResumeRel, id);
        }

        public List<TblTourGuideResumeRel> SelectTourGuideResumeRelByResumeId(int resumeId)
        {
            return new MainProvider().SelectTourGuideResumeRel(resumeId, MainProvider.TourGuideResumeRel.ResumeId);
        }

        public List<TblTourGuideResumeRel> SelectTourGuideResumeRelByTourGuideId(int tourGuideId)
        {
            return new MainProvider().SelectTourGuideResumeRel(tourGuideId,
                MainProvider.TourGuideResumeRel.TourGuideId);
        }
    }
}