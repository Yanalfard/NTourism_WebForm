using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblEquipment
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblEquipment(TblEquipment equipment, HttpStatusCode statusEffect)
        {
            id = equipment.id;
            Name = equipment.Name;
            Logo = equipment.Logo;
            StatusEffect = statusEffect;
        }

        public DtoTblEquipment()
        {
        }
    }
}