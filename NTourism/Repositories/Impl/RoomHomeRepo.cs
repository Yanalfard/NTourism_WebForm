using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class RoomHomeRepo : IRoomHomeRepo
    {
        public TblRoomHome AddRoomHome(TblRoomHome roomHome)
        {
            return (TblRoomHome)new MainProvider().Add(roomHome);
        }
        public bool DeleteRoomHome(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblRoomHome, id);
        }
        public bool UpdateRoomHome(TblRoomHome roomHome, int logId)
        {
            return new MainProvider().Update(roomHome, logId);
        }
        public List<TblRoomHome> SelectAllRoomHomes()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblRoomHome).Cast<TblRoomHome>().ToList();
        }
        public TblRoomHome SelectRoomHomeById(int id)
        {
            return (TblRoomHome)new MainProvider().SelectById(MainProvider.Tables.TblRoomHome, id);
        }
        public TblRoomHome SelectRoomHomeByName(string name)
        {
            return new MainProvider().SelectRoomHomeByName(name);
        }
        public List<TblRoomHome> SelectRoomHomeByClientId(int clientId)
        {
            return new MainProvider().SelectRoomHomeByClientId(clientId);
        }
        public List<TblRoomHome> SelectRoomHomeByCityId(int cityId)
        {
            return new MainProvider().SelectRoomHomeByCityId(cityId);
        }
        public List<TblRoomHome> SelectRoomHomeByIsReserved(bool isReserved)
        {
            return new MainProvider().SelectRoomHomeByIsReserved(isReserved);
        }

        public List<TblRoomHome> SelectRoomHomeByIsSelected(bool isSelected)
        {
            return new MainProvider().SelectRoomHomeByIsSelected(isSelected);
        }
    }
}