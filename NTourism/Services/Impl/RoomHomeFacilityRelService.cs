using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class RoomHomeFacilityRelService : IRoomHomeFacilityRelService
    {
        public TblRoomHomeFacilityRel AddRoomHomeFacilityRel(TblRoomHomeFacilityRel hotelFacilityRel)
        {
            return new RoomHomeFacilityRelRepo().AddRoomHomeFacilityRel(hotelFacilityRel);
        }

        public bool DeleteRoomHomeFacilityRel(int id)
        {
            return new RoomHomeFacilityRelRepo().DeleteRoomHomeFacilityRel(id);
        }

        public bool UpdateRoomHomeFacilityRel(TblRoomHomeFacilityRel hotelFacilityRel, int logId)
        {
            return new RoomHomeFacilityRelRepo().UpdateRoomHomeFacilityRel(hotelFacilityRel, logId);
        }

        public List<TblRoomHomeFacilityRel> SelectAllRoomHomeFacilityRels()
        {
            return new RoomHomeFacilityRelRepo().SelectAllRoomHomeFacilityRels();
        }

        public TblRoomHomeFacilityRel SelectRoomHomeFacilityRelById(int id)
        {
            return new RoomHomeFacilityRelRepo().SelectRoomHomeFacilityRelById(id);
        }

        public List<TblRoomHomeFacilityRel> SelectRoomHomeFacilityRelByFacilityId(int facilityId)
        {
            return new RoomHomeFacilityRelRepo().SelectRoomHomeFacilityRelByFacilityId(facilityId);
        }

        public List<TblRoomHomeFacilityRel> SelectRoomHomeFacilityRelByRoomHomeId(int roomHomeId)
        {
            return new RoomHomeFacilityRelRepo().SelectRoomHomeFacilityRelByRoomHomeId(roomHomeId);
        }
    }
}