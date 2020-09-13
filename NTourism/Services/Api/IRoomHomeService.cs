using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;

namespace NTourism.Services.Api
{
    public interface IRoomHomeService : IRoomHomeRepo
    {
        List<TblComments> SelectCommentsByRoomHome(int roomHomeId);
        List<TblFacility> SelectFacilitiesByRoomHome(int roomHomeId);
        List<TblImages> SelectImagesByRoomHome(int roomHomeId);
    }
}