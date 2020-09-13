using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class CityAttractionRelService : ICityAttractionRelService
    {
        public TblCityAttractionRel AddCityAttractionRel(TblCityAttractionRel cityAttractionRel)
        {
            return (TblCityAttractionRel)new CityAttractionRelRepo().AddCityAttractionRel(cityAttractionRel);
        }
        public bool DeleteCityAttractionRel(int id)
        {
            return new CityAttractionRelRepo().DeleteCityAttractionRel(id);
        }
        public bool UpdateCityAttractionRel(TblCityAttractionRel cityAttractionRel, int logId)
        {
            return new CityAttractionRelRepo().UpdateCityAttractionRel(cityAttractionRel, logId);
        }
        public List<TblCityAttractionRel> SelectAllCityAttractionRels()
        {
            return new CityAttractionRelRepo().SelectAllCityAttractionRels();
        }
        public TblCityAttractionRel SelectCityAttractionRelById(int id)
        {
            return (TblCityAttractionRel)new CityAttractionRelRepo().SelectCityAttractionRelById(id);
        }
        public List<TblCityAttractionRel> SelectCityAttractionRelByAttractionId(int attractionId)
        {
            return new CityAttractionRelRepo().SelectCityAttractionRelByAttractionId(attractionId);
        }
        public List<TblCityAttractionRel> SelectCityAttractionRelByRoomHomeId(int roomHomeId)
        {
            return new CityAttractionRelRepo().SelectCityAttractionRelByRoomHomeId(roomHomeId);
        }
        public List<TblCityAttractionRel> SelectCityAttractionRelByCityId(int cityId)
        {
            return new CityAttractionRelRepo().SelectCityAttractionRelByCityId(cityId);
        }

    }
}