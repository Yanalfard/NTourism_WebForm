using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IRoomHomeRepo
    {
        TblRoomHome AddRoomHome(TblRoomHome roomHome);
        bool DeleteRoomHome(int id);
        bool UpdateRoomHome(TblRoomHome roomHome, int logId);
        List<TblRoomHome> SelectAllRoomHomes();
        TblRoomHome SelectRoomHomeById(int id);
        TblRoomHome SelectRoomHomeByName(string name);
        List<TblRoomHome> SelectRoomHomeByClientId(int clientId);
        List<TblRoomHome> SelectRoomHomeByCityId(int cityId);
        List<TblRoomHome> SelectRoomHomeByIsReserved(bool isReserved);
        List<TblRoomHome> SelectRoomHomeByIsSelected(bool isSelected);

    }
}