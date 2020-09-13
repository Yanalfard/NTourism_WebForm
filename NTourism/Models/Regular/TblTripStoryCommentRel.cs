namespace NTourism.Models.Regular
{
    public class TblTripStoryCommentRel
    {
        public int id { get; set; }
        public int TripStoryId { get; set; }
        public int CommentId { get; set; }

        public TblTripStoryCommentRel(int id)
        {
            this.id = id;
        }

		public TblTripStoryCommentRel(int id, int tripStoryId, int commentId)
        {
            this.id = id;
            TripStoryId = tripStoryId;
            CommentId = commentId;
        }
        public TblTripStoryCommentRel(int tripStoryId, int commentId)
        {
            TripStoryId = tripStoryId;
            CommentId = commentId;
        }

        public TblTripStoryCommentRel()
        {
            
        }
    }
}