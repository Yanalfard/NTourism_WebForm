namespace NTourism.Models.Regular
{
    public class TblRoomHomeCommentsRel
    {
        public int id { get; set; }

        public int RoomHomeId { get; set; }

        public int CommentId { get; set; }

        public TblRoomHomeCommentsRel(int id)
        {
            this.id = id;
        }

        public TblRoomHomeCommentsRel(int hotelId, int commentId)
        {
            RoomHomeId = hotelId;
            CommentId = commentId;
        }

        public TblRoomHomeCommentsRel(int id, int hotelId, int commentId)
        {
            this.id = id;
            RoomHomeId = hotelId;
            CommentId = commentId;
        }

        public TblRoomHomeCommentsRel()
        {
        }
    }
}