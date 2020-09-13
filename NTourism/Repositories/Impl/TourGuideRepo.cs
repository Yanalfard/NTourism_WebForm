using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class TourGuideRepo : ITourGuideRepo
    {
        public TblTourGuide AddTourGuide(TblTourGuide tourGuide)
        {
            return (TblTourGuide)new MainProvider().Add(tourGuide);
        }

        public bool DeleteTourGuide(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblTourGuide, id);
        }

        public bool UpdateTourGuide(TblTourGuide tourGuide, int logId)
        {
            return new MainProvider().Update(tourGuide, logId);
        }

        public List<TblTourGuide> SelectAllTourGuides()
        {           
            return new MainProvider().SelectAll(MainProvider.Tables.TblTourGuide).Cast<TblTourGuide>().ToList();
        }

        public TblTourGuide SelectTourGuideById(int id)
        {
            return (TblTourGuide)new MainProvider().SelectById(MainProvider.Tables.TblTourGuide, id);
        }

        public TblTourGuide SelectTourGuideByTellNo(string tellNo)
        {
            return new MainProvider().SelectTourGuideByTellNo(tellNo);
        }

        public TblTourGuide SelectTourGuideByEmail(string email)
        {
            return new MainProvider().SelectTourGuideByEmail(email);
        }

        public TblTourGuide SelectTourGuideByUsername(string username)
        {
            return new MainProvider().SelectTourGuideByUsername(username);
        }

        public List<TblTourGuide> SelectTourGuideByCityId(int cityId)
        {
            return new MainProvider().SelectTourGuideByCityId(cityId);
        }

        public List<TblTourGuide> SelectTourGuideByDiscount(int cityId)
        {
            return new MainProvider().SelectTourGuideByDiscount(cityId);
        }
    }
}