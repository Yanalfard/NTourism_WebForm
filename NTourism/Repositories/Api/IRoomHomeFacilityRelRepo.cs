using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IRoomHomeFacilityRelRepo
    {
        TblRoomHomeFacilityRel AddRoomHomeFacilityRel(TblRoomHomeFacilityRel hotelFacilityRel);
        bool DeleteRoomHomeFacilityRel(int id);
        bool UpdateRoomHomeFacilityRel(TblRoomHomeFacilityRel hotelFacilityRel, int logId);
        List<TblRoomHomeFacilityRel> SelectAllRoomHomeFacilityRels();
        TblRoomHomeFacilityRel SelectRoomHomeFacilityRelById(int id);
        List<TblRoomHomeFacilityRel> SelectRoomHomeFacilityRelByFacilityId(int facility);
        List<TblRoomHomeFacilityRel> SelectRoomHomeFacilityRelByRoomHomeId(int roomHomeId);
    }
}