using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class TourGuideEquipmentRelService : ITourGuideEquipmentRelService
    {
        public TblTourGuideEquipmentRel AddTourGuideEquipmentRel(TblTourGuideEquipmentRel tourGuideEquipmentRel)
        {
            return (TblTourGuideEquipmentRel)new TourGuideEquipmentRelService().AddTourGuideEquipmentRel(tourGuideEquipmentRel);
        }

        public bool DeleteTourGuideEquipmentRel(int id)
        {
            return new TourGuideEquipmentRelService().DeleteTourGuideEquipmentRel(id);
        }

        public bool UpdateTourGuideEquipmentRel(TblTourGuideEquipmentRel tourGuideEquipmentRel, int logId)
        {
            return new TourGuideEquipmentRelService().UpdateTourGuideEquipmentRel(tourGuideEquipmentRel, logId);
        }

        public List<TblTourGuideEquipmentRel> SelectAllTourGuideEquipmentRels()
        {
            return new TourGuideEquipmentRelService().SelectAllTourGuideEquipmentRels();
        }

        public TblTourGuideEquipmentRel SelectTourGuideEquipmentRelById(int id)
        {
            return new TourGuideEquipmentRelService().SelectTourGuideEquipmentRelById(id);
        }

        public List<TblTourGuideEquipmentRel> SelectTourGuideEquipmentRelByEquipmentId(int equipmentId)
        {
            return new TourGuideEquipmentRelService().SelectTourGuideEquipmentRelByEquipmentId(equipmentId);
        }

        public List<TblTourGuideEquipmentRel> SelectTourGuideEquipmentRelByTourGuideId(int tourGuideId)
        {
            return new TourGuideEquipmentRelService().SelectTourGuideEquipmentRelByTourGuideId(tourGuideId);
        }
    }
}