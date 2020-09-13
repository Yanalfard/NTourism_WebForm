using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblCityAttractionRel
    {
        public int id { get; set; }
        public int AttractionId { get; set; }
        public int RoomHomeId { get; set; }
        public int CityId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public TblCityAttractionRel ToRegular()
        {
            return new TblCityAttractionRel(id, AttractionId, RoomHomeId, CityId);
        }

        public DtoTblCityAttractionRel(TblCityAttractionRel cityAttractionRel, HttpStatusCode statusEffect)
        {
            id = cityAttractionRel.id;
            AttractionId = cityAttractionRel.AttractionId;
            RoomHomeId = cityAttractionRel.RoomHomeId;
            CityId = cityAttractionRel.CityId;

            StatusEffect = statusEffect;
        }

        public DtoTblCityAttractionRel()
        {
        }
    }
}