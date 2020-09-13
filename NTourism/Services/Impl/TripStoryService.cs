using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class TripStoryService : ITripStoryService
    {
        public TblTripStory AddTripStory(TblTripStory tripStory)
        {
            return (TblTripStory)new TripStoryRepo().AddTripStory(tripStory);
        }
        public bool DeleteTripStory(int id)
        {
            return new TripStoryRepo().DeleteTripStory(id);
        }
        public bool UpdateTripStory(TblTripStory tripStory, int logId)
        {
            return new TripStoryRepo().UpdateTripStory(tripStory, logId);
        }
        public List<TblTripStory> SelectAllTripStorys()
        {
            return new TripStoryRepo().SelectAllTripStorys();
        }
        public TblTripStory SelectTripStoryById(int id)
        {
            return (TblTripStory)new TripStoryRepo().SelectTripStoryById(id);
        }
        public TblTripStory SelectTripStoryByTitle(string title)
        {
            return new TripStoryRepo().SelectTripStoryByTitle(title);
        }
        public List<TblTripStory> SelectTripStoryByCityId(int cityId)
        {
            return new TripStoryRepo().SelectTripStoryByCityId(cityId);
        }
        public List<TblTripStory> SelectTripStoryByTextId(int textId)
        {
            return new TripStoryRepo().SelectTripStoryByTextId(textId);
        }
        public List<TblTripStory> SelectTripStoryByImageId(int imageId)
        {
            return new TripStoryRepo().SelectTripStoryByImageId(imageId);
        }
        public List<TblComments>SelectCommentsByTripStory(int tripStoryId)
        {
            List<TblTripStoryCommentRel> stp1 = new TripStoryCommentRelRepo().SelectTripStoryCommentRelByTripStoryId(tripStoryId);
            List<TblComments> stp2 = new List<TblComments>();
            foreach (TblTripStoryCommentRel rel in stp1)
                stp2.Add(new CommentsRepo().SelectCommentById(rel.id));
            return stp2;
        }

    }
}