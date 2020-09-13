using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class CityAttractionRelRepo : ICityAttractionRelRepo
    {
        public TblCityAttractionRel AddCityAttractionRel(TblCityAttractionRel cityAttractionRel)
        {
            return (TblCityAttractionRel)new MainProvider().Add(cityAttractionRel);
        }
        public bool DeleteCityAttractionRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblCityAttractionRel, id);
        }
        public bool UpdateCityAttractionRel(TblCityAttractionRel cityAttractionRel, int logId)
        {
            return new MainProvider().Update(cityAttractionRel, logId);
        }
        public List<TblCityAttractionRel> SelectAllCityAttractionRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblCityAttractionRel).Cast<TblCityAttractionRel>().ToList();
        }
        public TblCityAttractionRel SelectCityAttractionRelById(int id)
        {
            return (TblCityAttractionRel)new MainProvider().SelectById(MainProvider.Tables.TblCityAttractionRel, id);
        }
        public List<TblCityAttractionRel> SelectCityAttractionRelByAttractionId(int attractionId)
        {
            return new MainProvider().SelectCityAttractionRel(attractionId, MainProvider.CityAttractionRel.AttractionId);
        }
        public List<TblCityAttractionRel> SelectCityAttractionRelByRoomHomeId(int roomHomeId)
        {
            return new MainProvider().SelectCityAttractionRel(roomHomeId, MainProvider.CityAttractionRel.RoomHomeId);
        }
        public List<TblCityAttractionRel> SelectCityAttractionRelByCityId(int cityId)
        {
            return new MainProvider().SelectCityAttractionRel(cityId, MainProvider.CityAttractionRel.CityId);
        }

    }
}