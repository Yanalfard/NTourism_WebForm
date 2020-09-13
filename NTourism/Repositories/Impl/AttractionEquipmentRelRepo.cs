using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class AttractionEquipmentRelRepo : IAttractionEquipmentRelRepo
    {
        public TblAttractionEquipmentRel AddAttractionEquipmentRel(TblAttractionEquipmentRel AttractionEquipmentRel)
        {
            return (TblAttractionEquipmentRel)new MainProvider().Add(AttractionEquipmentRel);
        }
        public bool DeleteAttractionEquipmentRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblAttractionEquipmentRel, id);
        }
        public bool UpdateAttractionEquipmentRel(TblAttractionEquipmentRel AttractionEquipmentRel, int logId)
        {
            return new MainProvider().Update(AttractionEquipmentRel, logId);
        }
        public List<TblAttractionEquipmentRel> SelectAllAttractionEquipmentRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblAttractionEquipmentRel).Cast<TblAttractionEquipmentRel>().ToList();
        }
        public TblAttractionEquipmentRel SelectAttractionEquipmentRelById(int id)
        {
            return (TblAttractionEquipmentRel)new MainProvider().SelectById(MainProvider.Tables.TblAttractionEquipmentRel, id);
        }

        public List<TblAttractionEquipmentRel> SelectAttractionEquipmentRelByAttractionId(int AttractionId)
        {
            return new MainProvider().SelectAttractionEquipmentRel(AttractionId, MainProvider.AttractionEquipmentRel.AttractionId);
        }
        public List<TblAttractionEquipmentRel> SelectAttractionEquipmentRelByEquipmentId(int equipmentId)
        {
            return new MainProvider().SelectAttractionEquipmentRel(equipmentId, MainProvider.AttractionEquipmentRel.EquipmentId);
        }

    }
}