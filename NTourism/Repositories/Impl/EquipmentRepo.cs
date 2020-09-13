using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class EquipmentRepo: IEquipmentRepo
    {
        public TblEquipment AddEquipment(TblEquipment equipment)
        {
            return (TblEquipment)new MainProvider().Add(equipment);
        }

        public bool DeleteEquipment(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblEquipment, id);
        }

        public bool UpdateEquipment(TblEquipment equipment, int logId)
        {
            return new MainProvider().Update(equipment, logId);
        }

        public List<TblEquipment> SelectAllEquipments()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblEquipment).Cast<TblEquipment>().ToList();
        }

        public TblEquipment SelectEquipmentById(int id)
        {
            return (TblEquipment)new MainProvider().SelectById(MainProvider.Tables.TblEquipment, id);
        }

        public TblEquipment SelectEquipmentByName(string name)
        {
            return new MainProvider().SelectEquipmentByName(name);
        }
    }
}