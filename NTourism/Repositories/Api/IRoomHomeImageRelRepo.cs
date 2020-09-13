using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IRoomHomeImageRelRepo
    {
        TblRoomHomeImageRel AddRoomHomeImageRel(TblRoomHomeImageRel hotelImageRel);
        bool DeleteRoomHomeImageRel(int id);
        bool UpdateRoomHomeImageRel(TblRoomHomeImageRel hotelImageRel, int logId);
        List<TblRoomHomeImageRel> SelectAllRoomHomeImageRels();
        TblRoomHomeImageRel SelectRoomHomeImageRelById(int id);
        List<TblRoomHomeImageRel> SelectRoomHomeImageRelByImageId(int imageId);
        List<TblRoomHomeImageRel> SelectRoomHomeImageRelByRoomHomeId(int hotelId);
    }
}