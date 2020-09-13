using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblRoomHomeFacilityRel
    {
        public int id { get; set; }

        public int RoomHomeId { get; set; }

        public int FacilityId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblRoomHomeFacilityRel(TblRoomHomeFacilityRel hotelFacilityRel, HttpStatusCode statusEffect)
        {
            id = hotelFacilityRel.id;
            RoomHomeId = hotelFacilityRel.RoomHomeId;
            FacilityId = hotelFacilityRel.FacilityId;
            StatusEffect = statusEffect;
        }

        public DtoTblRoomHomeFacilityRel()
        {
        }
    }
}