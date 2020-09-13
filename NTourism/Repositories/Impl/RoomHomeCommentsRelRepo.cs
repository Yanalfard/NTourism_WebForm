using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class RoomHomeCommentsRelRepo: IRoomHomeCommentsRelRepo
    {
        public TblRoomHomeCommentsRel AddRoomHomeCommentsRel(TblRoomHomeCommentsRel hotelCommentsRel)
        {
            return (TblRoomHomeCommentsRel)new MainProvider().Add(hotelCommentsRel);
        }

        public bool DeleteRoomHomeCommentsRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblAttractionCommentsRel, id);
        }

        public bool UpdateRoomHomeCommentsRel(TblRoomHomeCommentsRel hotelCommentsRel, int logId)
        {
            return new MainProvider().Update(hotelCommentsRel, logId);
        }

        public List<TblRoomHomeCommentsRel> SelectAllRoomHomeCommentsRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblRoomHomeCommentsRel)
                .Cast<TblRoomHomeCommentsRel>().ToList();
        }

        public TblRoomHomeCommentsRel SelectRoomHomeCommentsRelById(int id)
        {
            return (TblRoomHomeCommentsRel) new MainProvider().SelectById(MainProvider.Tables.TblRoomHomeCommentsRel, id);
        }

        public List<TblRoomHomeCommentsRel> SelectRoomHomeCommentsRelByRoomHomeId(int AttractionId)
        {
            return new MainProvider().SelectHotelCommentsRel(AttractionId,MainProvider.HotelCommentsRel.RoomHomeId);
        }

        public List<TblRoomHomeCommentsRel> SelectRoomHomeCommentsRelByCommentId(int commentId)
        {
            return new MainProvider().SelectHotelCommentsRel(commentId, MainProvider.HotelCommentsRel.CommentId);
        }
    }
}