using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ITripStoryCommentRelRepo
    {
        TblTripStoryCommentRel AddTripStoryCommentRel(TblTripStoryCommentRel tripStoryCommentRel);
        bool DeleteTripStoryCommentRel(int id);
        bool UpdateTripStoryCommentRel(TblTripStoryCommentRel tripStoryCommentRel, int logId);
        List<TblTripStoryCommentRel> SelectAllTripStoryCommentRels();
        TblTripStoryCommentRel SelectTripStoryCommentRelById(int id);
        List<TblTripStoryCommentRel> SelectTripStoryCommentRelByTripStoryId(int tripStoryId);
        List<TblTripStoryCommentRel> SelectTripStoryCommentRelByCommentId(int commentId);

    }
}