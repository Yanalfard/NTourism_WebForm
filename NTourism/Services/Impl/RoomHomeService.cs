using System;
using System.Collections.Generic;
using NTourism.Models.ObjectClass;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;
using NTourism.Utilities;

namespace NTourism.Services.Impl
{
    public class RoomHomeService : IRoomHomeService
    {
        public List<TblComments> SelectCommentsByRoomHome(int roomHomeId)
        {
            List<TblRoomHomeCommentsRel> stp1 = new RoomHomeCommentsRelRepo().SelectRoomHomeCommentsRelByRoomHomeId(roomHomeId);
            List<TblComments> stp2 = new List<TblComments>();
            foreach (TblRoomHomeCommentsRel rel in stp1)
                stp2.Add(new CommentsRepo().SelectCommentById(rel.CommentId));

            return stp2;
        }

        public List<TblFacility> SelectFacilitiesByRoomHome(int roomHomeId)
        {
            List<TblRoomHomeFacilityRel> stp1 = new RoomHomeFacilityRelRepo().SelectRoomHomeFacilityRelByRoomHomeId(roomHomeId);
            List<TblFacility> stp2 = new List<TblFacility>();
            foreach (TblRoomHomeFacilityRel rel in stp1)
                stp2.Add(new FacilityRepo().SelectFacilityById(rel.FacilityId));

            return stp2;
        }
        public List<TblImages> SelectImagesByRoomHome(int roomHomeId)
        {
            List<TblRoomHomeImageRel> stp1 = new RoomHomeImageRelRepo().SelectRoomHomeImageRelByRoomHomeId(roomHomeId);
            List<TblImages> stp2 = new List<TblImages>();
            foreach (TblRoomHomeImageRel rel in stp1)
                stp2.Add(new ImagesRepo().SelectImageById(rel.ImageId));

            return stp2;
        }

        public TblRoomHome AddRoomHome(TblRoomHome roomHome)
        {
            return (TblRoomHome)new RoomHomeRepo().AddRoomHome(roomHome);
        }

        public bool DeleteRoomHome(int id)
        {
            return new RoomHomeRepo().DeleteRoomHome(id);
        }

        public bool UpdateRoomHome(TblRoomHome roomHome, int logId)
        {
            return new RoomHomeRepo().UpdateRoomHome(roomHome, logId);
        }

        public List<TblRoomHome> SelectAllRoomHomes()
        {
            return new RoomHomeRepo().SelectAllRoomHomes();
        }

        public TblRoomHome SelectRoomHomeById(int id)
        {
            return new RoomHomeRepo().SelectRoomHomeById(id);
        }

        public TblRoomHome SelectRoomHomeByName(string name)
        {
            return new RoomHomeRepo().SelectRoomHomeByName(name);
        }

        public List<TblRoomHome> SelectRoomHomeByClientId(int clientId)
        {
            return new RoomHomeRepo().SelectRoomHomeByClientId(clientId);
        }

        public List<TblRoomHome> SelectRoomHomeByCityId(int cityId)
        {
            return new RoomHomeRepo().SelectRoomHomeByCityId(cityId);
        }

        public List<TblRoomHome> SelectRoomHomeByIsReserved(bool isReserved)
        {
            return new RoomHomeRepo().SelectRoomHomeByIsReserved(isReserved);
        }

        public List<TblRoomHome> SelectRoomHomeByIsSelected(bool isSelected)
        {
            List<TblRoomHome> roomHomes = new RoomHomeRepo().SelectRoomHomeByIsSelected(isSelected);
            MethodRepo.Shuffle(roomHomes);
            return roomHomes;
        }
    }
}