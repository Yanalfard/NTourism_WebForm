using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblTourGuideEquipmentRel
    {
        public int id { get; set; }

        public int TourGuideId { get; set; }

        public int EquipmentId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblTourGuideEquipmentRel(TblTourGuideEquipmentRel tourGuideEquipmentRel, HttpStatusCode statusEffect)
        {
            id = tourGuideEquipmentRel.id;
            TourGuideId = tourGuideEquipmentRel.TourGuideId;
            EquipmentId = tourGuideEquipmentRel.EquipmentId;
            StatusEffect = statusEffect;
        }

        public DtoTblTourGuideEquipmentRel()
        {
        }
    }
}