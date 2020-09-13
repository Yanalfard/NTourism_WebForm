using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class TripStoryCommentRelService : ITripStoryCommentRelService
    {
        public TblTripStoryCommentRel AddTripStoryCommentRel(TblTripStoryCommentRel tripStoryCommentRel)
        {
            return (TblTripStoryCommentRel)new TripStoryCommentRelRepo().AddTripStoryCommentRel(tripStoryCommentRel);
        }
        public bool DeleteTripStoryCommentRel(int id)
        {
            return new TripStoryCommentRelRepo().DeleteTripStoryCommentRel(id);
        }
        public bool UpdateTripStoryCommentRel(TblTripStoryCommentRel tripStoryCommentRel, int logId)
        {
            return new TripStoryCommentRelRepo().UpdateTripStoryCommentRel(tripStoryCommentRel, logId);
        }
        public List<TblTripStoryCommentRel> SelectAllTripStoryCommentRels()
        {
            return new TripStoryCommentRelRepo().SelectAllTripStoryCommentRels();
        }
        public TblTripStoryCommentRel SelectTripStoryCommentRelById(int id)
        {
            return (TblTripStoryCommentRel)new TripStoryCommentRelRepo().SelectTripStoryCommentRelById(id);
        }
        public List<TblTripStoryCommentRel> SelectTripStoryCommentRelByTripStoryId(int tripStoryId)
        {
            return new TripStoryCommentRelRepo().SelectTripStoryCommentRelByTripStoryId(tripStoryId);
        }
        public List<TblTripStoryCommentRel> SelectTripStoryCommentRelByCommentId(int commentId)
        {
            return new TripStoryCommentRelRepo().SelectTripStoryCommentRelByCommentId(commentId);
        }

    }
}