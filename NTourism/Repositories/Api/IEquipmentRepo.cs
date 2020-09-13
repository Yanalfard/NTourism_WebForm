using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IEquipmentRepo
    {
        TblEquipment AddEquipment(TblEquipment equipment);
        bool DeleteEquipment(int id);
        bool UpdateEquipment(TblEquipment equipment, int logId);
        List<TblEquipment> SelectAllEquipments();
        TblEquipment SelectEquipmentById(int id);
        TblEquipment SelectEquipmentByName(string name);
    }
}