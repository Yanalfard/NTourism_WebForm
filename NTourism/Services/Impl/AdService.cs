using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class AdService : IAdService
    {
        public TblAd AddAd(TblAd ad)
        {
            return (TblAd)new AdRepo().AddAd(ad);
        }
        public bool DeleteAd(int id)
        {
            return new AdRepo().DeleteAd(id);
        }
        public bool UpdateAd(TblAd ad, int logId)
        {
            return new AdRepo().UpdateAd(ad, logId);
        }
        public List<TblAd> SelectAllAds()
        {
            return new AdRepo().SelectAllAds();
        }
        public TblAd SelectAdById(int id)
        {
            return (TblAd)new AdRepo().SelectAdById(id);
        }
        public TblAd SelectAdByImage(string image)
        {
            return new AdRepo().SelectAdByImage(image);
        }
        public List<TblAd> SelectAdByPositionId(int positionId)
        {
            return new AdRepo().SelectAdByPositionId(positionId);
        }
        public List<TblAd> SelectAdByIsAvailable(bool isAvailable)
        {
            return new AdRepo().SelectAdByIsAvailable(isAvailable);
        }

    }
}