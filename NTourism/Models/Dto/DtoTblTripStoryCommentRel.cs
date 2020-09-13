using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblTripStoryCommentRel
    {
        public int id { get; set; }
        public int TripStoryId { get; set; }
        public int CommentId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblTripStoryCommentRel(TblTripStoryCommentRel tripStoryCommentRel, HttpStatusCode statusEffect)
        {
            id = tripStoryCommentRel.id;
            TripStoryId = tripStoryCommentRel.TripStoryId;
            CommentId = tripStoryCommentRel.CommentId;

            StatusEffect = statusEffect;
        }

        public DtoTblTripStoryCommentRel()
        {
        }
    }
}