namespace NTourism.Models.Regular
{
    public class TblRoomHomeImageRel
    {
        public int id { get; set; }

        public int RoomHomeId { get; set; }

        public int ImageId { get; set; }

        public TblRoomHomeImageRel(int id)
        {
            this.id = id;
        }

        public TblRoomHomeImageRel(int hotelId, int imageId)
        {
            RoomHomeId = hotelId;
            ImageId = imageId;
        }

        public TblRoomHomeImageRel(int id, int hotelId, int imageId)
        {
            this.id = id;
            RoomHomeId = hotelId;
            ImageId = imageId;
        }

        public TblRoomHomeImageRel()
        {
        }
    }
}