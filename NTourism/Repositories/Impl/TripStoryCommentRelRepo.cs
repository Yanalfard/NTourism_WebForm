using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class TripStoryCommentRelRepo : ITripStoryCommentRelRepo
    {
        public TblTripStoryCommentRel AddTripStoryCommentRel(TblTripStoryCommentRel tripStoryCommentRel)
        {
            return (TblTripStoryCommentRel)new MainProvider().Add(tripStoryCommentRel);
        }
        public bool DeleteTripStoryCommentRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblTripStoryCommentRel, id);
        }
        public bool UpdateTripStoryCommentRel(TblTripStoryCommentRel tripStoryCommentRel, int logId)
        {
            return new MainProvider().Update(tripStoryCommentRel, logId);
        }
        public List<TblTripStoryCommentRel> SelectAllTripStoryCommentRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblTripStoryCommentRel).Cast<TblTripStoryCommentRel>().ToList();
        }
        public TblTripStoryCommentRel SelectTripStoryCommentRelById(int id)
        {
            return (TblTripStoryCommentRel)new MainProvider().SelectById(MainProvider.Tables.TblTripStoryCommentRel, id);
        }
        public List<TblTripStoryCommentRel> SelectTripStoryCommentRelByTripStoryId(int tripStoryId)
        {
            return new MainProvider().SelectTripStoryCommentRel(tripStoryId, MainProvider.TripStoryCommentRel.TripStoryId);
        }
        public List<TblTripStoryCommentRel> SelectTripStoryCommentRelByCommentId(int commentId)
        {
            return new MainProvider().SelectTripStoryCommentRel(commentId, MainProvider.TripStoryCommentRel.CommentId);
        }

    }
}