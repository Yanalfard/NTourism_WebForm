using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IRoomHomeCommentsRelRepo
    {
        TblRoomHomeCommentsRel AddRoomHomeCommentsRel(TblRoomHomeCommentsRel hotelCommentsRel);
        bool DeleteRoomHomeCommentsRel(int id);
        bool UpdateRoomHomeCommentsRel(TblRoomHomeCommentsRel hotelCommentsRel, int logId);
        List<TblRoomHomeCommentsRel> SelectAllRoomHomeCommentsRels();
        TblRoomHomeCommentsRel SelectRoomHomeCommentsRelById(int id);
        List<TblRoomHomeCommentsRel> SelectRoomHomeCommentsRelByRoomHomeId(int hotelId);       
        List<TblRoomHomeCommentsRel> SelectRoomHomeCommentsRelByCommentId(int commentId);
    }
}