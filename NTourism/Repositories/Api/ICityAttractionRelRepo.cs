using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ICityAttractionRelRepo
    {
        TblCityAttractionRel AddCityAttractionRel(TblCityAttractionRel cityAttractionRel);
        bool DeleteCityAttractionRel(int id);
        bool UpdateCityAttractionRel(TblCityAttractionRel cityAttractionRel, int logId);
        List<TblCityAttractionRel> SelectAllCityAttractionRels();
        TblCityAttractionRel SelectCityAttractionRelById(int id);
        List<TblCityAttractionRel> SelectCityAttractionRelByAttractionId(int attractionId);
        List<TblCityAttractionRel> SelectCityAttractionRelByRoomHomeId(int roomHomeId);
        List<TblCityAttractionRel> SelectCityAttractionRelByCityId(int cityId);

    }
}