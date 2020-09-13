using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IAttractionEquipmentRelRepo
    {
        TblAttractionEquipmentRel AddAttractionEquipmentRel(TblAttractionEquipmentRel AttractionEquipmentRel);
        bool DeleteAttractionEquipmentRel(int id);
        bool UpdateAttractionEquipmentRel(TblAttractionEquipmentRel AttractionEquipmentRel, int logId);
        List<TblAttractionEquipmentRel> SelectAllAttractionEquipmentRels();
        TblAttractionEquipmentRel SelectAttractionEquipmentRelById(int id);
        List<TblAttractionEquipmentRel> SelectAttractionEquipmentRelByAttractionId(int AttractionId);
        List<TblAttractionEquipmentRel> SelectAttractionEquipmentRelByEquipmentId(int equipmentId);

    }
}