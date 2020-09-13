using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ITourGuideRepo
    {
        TblTourGuide AddTourGuide(TblTourGuide tourGuide);
        bool DeleteTourGuide(int id);
        bool UpdateTourGuide(TblTourGuide tourGuide, int logId);
        List<TblTourGuide> SelectAllTourGuides();
        TblTourGuide SelectTourGuideById(int id);
        TblTourGuide SelectTourGuideByTellNo(string tellNo);
        TblTourGuide SelectTourGuideByEmail(string email);
        TblTourGuide SelectTourGuideByUsername(string username);
        List<TblTourGuide> SelectTourGuideByCityId(int cityId);
        List<TblTourGuide> SelectTourGuideByDiscount(int cityId);

    }
}