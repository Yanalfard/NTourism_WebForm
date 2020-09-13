using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ITourGuideEquipmentRelRepo
    {
        TblTourGuideEquipmentRel AddTourGuideEquipmentRel(TblTourGuideEquipmentRel tourGuideEquipmentRel);
        bool DeleteTourGuideEquipmentRel(int id);
        bool UpdateTourGuideEquipmentRel(TblTourGuideEquipmentRel tourGuideEquipmentRel, int logId);
        List<TblTourGuideEquipmentRel> SelectAllTourGuideEquipmentRels();
        TblTourGuideEquipmentRel SelectTourGuideEquipmentRelById(int id);
        List<TblTourGuideEquipmentRel> SelectTourGuideEquipmentRelByEquipmentId(int equipmentId);
        List<TblTourGuideEquipmentRel> SelectTourGuideEquipmentRelByTourGuideId(int tourGuideId);
    }
}