namespace NTourism.Models.Regular
{
    public class TblAttractionCommentsRel
    {
        public int id { get; set; }

        public int AttractionId { get; set; }

        public int CommentId { get; set; }

        public TblAttractionCommentsRel(int id)
        {
            this.id = id;
        }

        public TblAttractionCommentsRel(int AttractionId, int commentId)
        {
            AttractionId = AttractionId;
            CommentId = commentId;
        }

        public TblAttractionCommentsRel(int id, int AttractionId, int commentId)
        {
            this.id = id;
            AttractionId = AttractionId;
            CommentId = commentId;
        }

        public TblAttractionCommentsRel()
        {
        }
    }
}