using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class AdRepo : IAdRepo
    {
        public TblAd AddAd(TblAd ad)
        {
            return (TblAd)new MainProvider().Add(ad);
        }
        public bool DeleteAd(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblAd, id);
        }
        public bool UpdateAd(TblAd ad, int logId)
        {
            return new MainProvider().Update(ad, logId);
        }
        public List<TblAd> SelectAllAds()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblAd).Cast<TblAd>().ToList();
        }
        public TblAd SelectAdById(int id)
        {
            return (TblAd)new MainProvider().SelectById(MainProvider.Tables.TblAd, id);
        }
        public TblAd SelectAdByImage(string image)
        {
            return new MainProvider().SelectAdByImage(image);
        }
        public List<TblAd> SelectAdByPositionId(int positionId)
        {
            return new MainProvider().SelectAdByPositionId(positionId);
        }
        public List<TblAd> SelectAdByIsAvailable(bool isAvailable)
        {
            return new MainProvider().SelectAdByIsAvailable(isAvailable);
        }

    }
}