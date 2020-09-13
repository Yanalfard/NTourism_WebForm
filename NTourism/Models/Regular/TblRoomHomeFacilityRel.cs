namespace NTourism.Models.Regular
{
    public class TblRoomHomeFacilityRel
    {
        public int id { get; set; }

        public int RoomHomeId { get; set; }

        public int FacilityId { get; set; }

        public TblRoomHomeFacilityRel(int id)
        {
            this.id = id;
        }

        public TblRoomHomeFacilityRel(int hotelId, int facilityId)
        {
            RoomHomeId = hotelId;
            FacilityId = facilityId;
        }

        public TblRoomHomeFacilityRel(int id, int hotelId, int facilityId)
        {
            this.id = id;
            RoomHomeId = hotelId;
            FacilityId = facilityId;
        }

        public TblRoomHomeFacilityRel()
        {
        }
    }
}