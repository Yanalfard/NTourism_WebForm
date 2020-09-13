namespace NTourism.Models.Regular
{
    public class TblAttractionEquipmentRel
    {
        public int id { get; set; }
        public int AttractionId { get; set; }
        public int EquipmentId { get; set; }

        public TblAttractionEquipmentRel(int id)
        {
            this.id = id;
        }

		public TblAttractionEquipmentRel(int id, int AttractionId, int equipmentId)
        {
            this.id = id;
            AttractionId = AttractionId;
            EquipmentId = equipmentId;
        }

        public TblAttractionEquipmentRel(int AttractionId, int equipmentId)
        {
            AttractionId = AttractionId;
            EquipmentId = equipmentId;
        }

        public TblAttractionEquipmentRel()
        {
            
        }
    }
}