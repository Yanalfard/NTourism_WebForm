using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class AttractionEquipmentRelService : IAttractionEquipmentRelService
    {
        public TblAttractionEquipmentRel AddAttractionEquipmentRel(TblAttractionEquipmentRel AttractionEquipmentRel)
        {
            return (TblAttractionEquipmentRel)new AttractionEquipmentRelRepo().AddAttractionEquipmentRel(AttractionEquipmentRel);
        }
        public bool DeleteAttractionEquipmentRel(int id)
        {
            return new AttractionEquipmentRelRepo().DeleteAttractionEquipmentRel(id);
        }
        public bool UpdateAttractionEquipmentRel(TblAttractionEquipmentRel AttractionEquipmentRel, int logId)
        {
            return new AttractionEquipmentRelRepo().UpdateAttractionEquipmentRel(AttractionEquipmentRel, logId);
        }
        public List<TblAttractionEquipmentRel> SelectAllAttractionEquipmentRels()
        {
            return new AttractionEquipmentRelRepo().SelectAllAttractionEquipmentRels();
        }
        public TblAttractionEquipmentRel SelectAttractionEquipmentRelById(int id)
        {
            return (TblAttractionEquipmentRel)new AttractionEquipmentRelRepo().SelectAttractionEquipmentRelById(id);
        }
        public List<TblAttractionEquipmentRel> SelectAttractionEquipmentRelByAttractionId(int AttractionId)
        {
            return new AttractionEquipmentRelRepo().SelectAttractionEquipmentRelByAttractionId(AttractionId);
        }
        public List<TblAttractionEquipmentRel> SelectAttractionEquipmentRelByEquipmentId(int equipmentId)
        {
            return new AttractionEquipmentRelRepo().SelectAttractionEquipmentRelByEquipmentId(equipmentId);
        }

    }
}