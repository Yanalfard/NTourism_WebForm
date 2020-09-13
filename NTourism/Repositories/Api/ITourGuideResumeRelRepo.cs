using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ITourGuideResumeRelRepo
    {
        TblTourGuideResumeRel AddTourGuideResumeRel(TblTourGuideResumeRel tourGuideResumeRel);
        bool DeleteTourGuideResumeRel(int id);
        bool UpdateTourGuideResumeRel(TblTourGuideResumeRel tourGuideResumeRel, int logId);
        List<TblTourGuideResumeRel> SelectAllTourGuideResumeRels();
        TblTourGuideResumeRel SelectTourGuideResumeRelById(int id);
        List<TblTourGuideResumeRel> SelectTourGuideResumeRelByResumeId(int resumeId);
        List<TblTourGuideResumeRel> SelectTourGuideResumeRelByTourGuideId(int tourGuideId);
    }
}