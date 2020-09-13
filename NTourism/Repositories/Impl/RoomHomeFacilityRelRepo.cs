using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class RoomHomeFacilityRelRepo: IRoomHomeFacilityRelRepo
    {
        public TblRoomHomeFacilityRel AddRoomHomeFacilityRel(TblRoomHomeFacilityRel hotelFacilityRel)
        {
            return (TblRoomHomeFacilityRel)new MainProvider().Add(hotelFacilityRel);
        }

        public bool DeleteRoomHomeFacilityRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblRoomHomeFacilityRel, id);
        }

        public bool UpdateRoomHomeFacilityRel(TblRoomHomeFacilityRel hotelFacilityRel, int logId)
        {
            return new MainProvider().Update(hotelFacilityRel, logId);
        }

        public List<TblRoomHomeFacilityRel> SelectAllRoomHomeFacilityRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblRoomHomeFacilityRel).Cast<TblRoomHomeFacilityRel>()
                .ToList();
        }

        public TblRoomHomeFacilityRel SelectRoomHomeFacilityRelById(int id)
        {
            return (TblRoomHomeFacilityRel)new MainProvider().SelectById(MainProvider.Tables.TblRoomHomeFacilityRel, id);
        }

        public List<TblRoomHomeFacilityRel> SelectRoomHomeFacilityRelByFacilityId(int facilityId)
        {
            return new MainProvider().SelectRoomHomeFacilityRel(facilityId, MainProvider.HotelFacilityRel.FacilityId);
        }

        public List<TblRoomHomeFacilityRel> SelectRoomHomeFacilityRelByRoomHomeId(int roomHomeId)
        {
            return new MainProvider().SelectRoomHomeFacilityRel(roomHomeId, MainProvider.HotelFacilityRel.RoomHomeId);
        }
    }
}