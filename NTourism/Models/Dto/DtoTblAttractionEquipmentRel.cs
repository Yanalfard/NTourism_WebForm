using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblAttractionEquipmentRel
    {
        public int id { get; set; }
        public int AttractionId { get; set; }
        public int EquipmentId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblAttractionEquipmentRel(TblAttractionEquipmentRel AttractionEquipmentRel, HttpStatusCode statusEffect)
        {
            id = AttractionEquipmentRel.id;
            AttractionId = AttractionEquipmentRel.AttractionId;
            EquipmentId = AttractionEquipmentRel.EquipmentId;

            StatusEffect = statusEffect;
        }

        public DtoTblAttractionEquipmentRel()
        {
        }
    }
}