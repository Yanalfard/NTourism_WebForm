using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblRoomHomeImageRel
    {
        public int id { get; set; }

        public int RoomHomeId { get; set; }

        public int ImageId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblRoomHomeImageRel(TblRoomHomeImageRel hotelImageRel, HttpStatusCode statusEffect)
        {
            id = hotelImageRel.id;
            RoomHomeId = hotelImageRel.RoomHomeId;
            ImageId = hotelImageRel.ImageId;
            StatusEffect = statusEffect;
        }

        public DtoTblRoomHomeImageRel()
        {
        }
    }
}