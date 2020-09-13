using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IAdRepo
    {
        TblAd AddAd(TblAd ad);
        bool DeleteAd(int id);
        bool UpdateAd(TblAd ad, int logId);
        List<TblAd> SelectAllAds();
        TblAd SelectAdById(int id);
        TblAd SelectAdByImage(string image);
        List<TblAd> SelectAdByPositionId(int positionId);
        List<TblAd> SelectAdByIsAvailable(bool isAvailable);

    }
}