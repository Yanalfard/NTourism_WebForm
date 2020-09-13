using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class RoomHomeCommentsRelService : IHotelCommentsRelService
    {
        public TblRoomHomeCommentsRel AddRoomHomeCommentsRel(TblRoomHomeCommentsRel hotelCommentsRel)
        {
            return (TblRoomHomeCommentsRel)new RoomHomeCommentsRelService().AddRoomHomeCommentsRel(hotelCommentsRel);
        }

        public bool DeleteRoomHomeCommentsRel(int id)
        {
            return new RoomHomeCommentsRelService().DeleteRoomHomeCommentsRel(id);
        }

        public bool UpdateRoomHomeCommentsRel(TblRoomHomeCommentsRel hotelCommentsRel, int logId)
        {
            return new RoomHomeCommentsRelService().UpdateRoomHomeCommentsRel(hotelCommentsRel, logId);
        }

        public List<TblRoomHomeCommentsRel> SelectAllRoomHomeCommentsRels()
        {
            return new RoomHomeCommentsRelService().SelectAllRoomHomeCommentsRels();
        }

        public TblRoomHomeCommentsRel SelectRoomHomeCommentsRelById(int id)
        {
            return new RoomHomeCommentsRelService().SelectRoomHomeCommentsRelById(id);
        }

        public List<TblRoomHomeCommentsRel> SelectRoomHomeCommentsRelByRoomHomeId(int hotelId)
        {
            return new RoomHomeCommentsRelService().SelectRoomHomeCommentsRelByRoomHomeId(hotelId);
        }

        public List<TblRoomHomeCommentsRel> SelectRoomHomeCommentsRelByCommentId(int commentId)
        {
            return new RoomHomeCommentsRelService().SelectRoomHomeCommentsRelByCommentId(commentId);
        }
    }
}