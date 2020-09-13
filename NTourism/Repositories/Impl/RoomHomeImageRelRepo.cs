using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class RoomHomeImageRelRepo: IRoomHomeImageRelRepo
    {
        public TblRoomHomeImageRel AddRoomHomeImageRel(TblRoomHomeImageRel hotelImageRel)
        {
            return (TblRoomHomeImageRel)new MainProvider().Add(hotelImageRel);
        }

        public bool DeleteRoomHomeImageRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblRoomHomeImageRel, id);
        }

        public bool UpdateRoomHomeImageRel(TblRoomHomeImageRel hotelImageRel, int logId)
        {
            return new MainProvider().Update(hotelImageRel, logId);
        }

        public List<TblRoomHomeImageRel> SelectAllRoomHomeImageRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblRoomHomeImageRel).Cast<TblRoomHomeImageRel>().ToList();
        }

        public TblRoomHomeImageRel SelectRoomHomeImageRelById(int id)
        {
            return (TblRoomHomeImageRel)new MainProvider().SelectById(MainProvider.Tables.TblRoomHomeImageRel, id);
        }

        public List<TblRoomHomeImageRel> SelectRoomHomeImageRelByImageId(int imageId)
        {
            return new MainProvider().SelectRoomHomeImageRel(imageId, MainProvider.RoomHomeImageRel.ImageId);
        }

        public List<TblRoomHomeImageRel> SelectRoomHomeImageRelByRoomHomeId(int hotelId)
        {
            return new MainProvider().SelectRoomHomeImageRel(hotelId, MainProvider.RoomHomeImageRel.RoomHomeId);
        }
    }
}