namespace NTourism.Models.Regular
{
    public class TblTourGuideEquipmentRel
    {
        public int id { get; set; }

        public int TourGuideId { get; set; }

        public int EquipmentId { get; set; }

        public TblTourGuideEquipmentRel(int id)
        {
            this.id = id;
        }

        public TblTourGuideEquipmentRel(int tourGuideId, int equipmentId)
        {
            TourGuideId = tourGuideId;
            EquipmentId = equipmentId;
        }

        public TblTourGuideEquipmentRel(int id, int tourGuideId, int equipmentId)
        {
            this.id = id;
            TourGuideId = tourGuideId;
            EquipmentId = equipmentId;
        }

        public TblTourGuideEquipmentRel()
        {
        }
    }
}