using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class EquipmentService : IEquipmentService
    {
        public TblEquipment AddEquipment(TblEquipment equipment)
        {
            return (TblEquipment)new EquipmentRepo().AddEquipment(equipment);
        }

        public bool DeleteEquipment(int id)
        {
            return new EquipmentRepo().DeleteEquipment(id);
        }

        public bool UpdateEquipment(TblEquipment equipment, int logId)
        {
            return new EquipmentRepo().UpdateEquipment(equipment, logId);
        }

        public List<TblEquipment> SelectAllEquipments()
        {
            return new EquipmentRepo().SelectAllEquipments();
        }

        public TblEquipment SelectEquipmentById(int id)
        {
            return new EquipmentRepo().SelectEquipmentById(id);
        }

        public TblEquipment SelectEquipmentByName(string name)
        {
            return new EquipmentRepo().SelectEquipmentByName(name);
        }
    }
}