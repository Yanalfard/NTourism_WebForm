using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Repositories.Impl;

namespace NTourism.Services.Impl
{
    public class RoomHomeImageRelService : IRoomHomeImageRelRepo
    {
        public TblRoomHomeImageRel AddRoomHomeImageRel(TblRoomHomeImageRel hotelImageRel)
        {
            return (TblRoomHomeImageRel)new RoomHomeImageRelRepo().AddRoomHomeImageRel(hotelImageRel);
        }

        public bool DeleteRoomHomeImageRel(int id)
        {
            return new RoomHomeImageRelRepo().DeleteRoomHomeImageRel(id);
        }

        public bool UpdateRoomHomeImageRel(TblRoomHomeImageRel hotelImageRel, int logId)
        {
            return new RoomHomeImageRelRepo().UpdateRoomHomeImageRel(hotelImageRel, logId);
        }

        public List<TblRoomHomeImageRel> SelectAllRoomHomeImageRels()
        {
            return new RoomHomeImageRelRepo().SelectAllRoomHomeImageRels();
        }

        public TblRoomHomeImageRel SelectRoomHomeImageRelById(int id)
        {
            return new RoomHomeImageRelRepo().SelectRoomHomeImageRelById(id);
        }

        public List<TblRoomHomeImageRel> SelectRoomHomeImageRelByImageId(int imageId)
        {
            return new RoomHomeImageRelRepo().SelectRoomHomeImageRelByImageId(imageId);
        }

        public List<TblRoomHomeImageRel> SelectRoomHomeImageRelByRoomHomeId(int hotelId)
        {
            return new RoomHomeImageRelRepo().SelectRoomHomeImageRelByRoomHomeId(hotelId);
        }
    }
}