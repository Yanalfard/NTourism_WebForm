using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblFacility
    {
        public int id { get; set; }

        public string Name { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblFacility(TblFacility facility, HttpStatusCode statusEffect)
        {
            id = facility.id;
            Name = facility.Name;
            StatusEffect = statusEffect;
        }

        public DtoTblFacility()
        {
        }
    }
}