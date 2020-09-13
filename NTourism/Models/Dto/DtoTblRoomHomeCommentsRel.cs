using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblRoomHomeCommentsRel
    {
        public int id { get; set; }

        public int RoomHomeId { get; set; }

        public int CommentId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblRoomHomeCommentsRel(TblRoomHomeCommentsRel hotelCommentsRel, HttpStatusCode statusEffect)
        {
            id = hotelCommentsRel.id;
            RoomHomeId = hotelCommentsRel.RoomHomeId;
            CommentId = hotelCommentsRel.CommentId;
            StatusEffect = statusEffect;
        }

        public DtoTblRoomHomeCommentsRel()
        {
        }
    }
}