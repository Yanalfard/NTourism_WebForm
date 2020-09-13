using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class TourGuideEquipmentRelRepo: ITourGuideEquipmentRelRepo
    {
        public TblTourGuideEquipmentRel AddTourGuideEquipmentRel(TblTourGuideEquipmentRel tourGuideEquipmentRel)
        {
            return (TblTourGuideEquipmentRel)new MainProvider().Add(tourGuideEquipmentRel);
        }

        public bool DeleteTourGuideEquipmentRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblTourGuideEquipmentRel, id);
        }

        public bool UpdateTourGuideEquipmentRel(TblTourGuideEquipmentRel tourGuideEquipmentRel, int logId)
        {
            return new MainProvider().Update(tourGuideEquipmentRel, logId);
        }

        public List<TblTourGuideEquipmentRel> SelectAllTourGuideEquipmentRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblTourGuideEquipmentRel)
                .Cast<TblTourGuideEquipmentRel>().ToList();
        }

        public TblTourGuideEquipmentRel SelectTourGuideEquipmentRelById(int id)
        {
            return (TblTourGuideEquipmentRel)new MainProvider().SelectById(MainProvider.Tables.TblTourGuideEquipmentRel, id);
        }

        public List<TblTourGuideEquipmentRel> SelectTourGuideEquipmentRelByEquipmentId(int equipmentId)
        {
            return new MainProvider().SelectTourGuideEquipmentRel(equipmentId,
                MainProvider.TourGuideEquipmentRel.EquipmentId);

        }

        public List<TblTourGuideEquipmentRel> SelectTourGuideEquipmentRelByTourGuideId(int tourGuideId)
        {
            return new MainProvider().SelectTourGuideEquipmentRel(tourGuideId,
                MainProvider.TourGuideEquipmentRel.TourGuideId);
        }
    }
}