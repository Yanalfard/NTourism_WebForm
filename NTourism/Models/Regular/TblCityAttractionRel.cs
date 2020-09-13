namespace NTourism.Models.Regular
{
    public class TblCityAttractionRel
    {
        public int id { get; set; }
        public int AttractionId { get; set; }
        public int RoomHomeId { get; set; }
        public int CityId { get; set; }

        public TblCityAttractionRel(int id)
        {
            this.id = id;
        }

		public TblCityAttractionRel(int id, int attractionId, int roomHomeId, int cityId)
        {
            this.id = id;
            AttractionId = attractionId;
            RoomHomeId = roomHomeId;
            CityId = cityId;
        }
        public TblCityAttractionRel(int attractionId, int roomHomeId, int cityId)
        {
            AttractionId = attractionId;
            RoomHomeId = roomHomeId;
            CityId = cityId;
        }

        public TblCityAttractionRel()
        {
            
        }
    }
}