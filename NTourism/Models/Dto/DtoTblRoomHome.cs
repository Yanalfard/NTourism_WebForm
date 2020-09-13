using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblRoomHome
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string MainImage { get; set; }
        public int ClientId { get; set; }
        public int CityId { get; set; }
        public long PriceNormal { get; set; }
        public long PriceWeekend { get; set; }
        public int DaysOccupaid { get; set; }
        public string OccupaidFrom { get; set; }
        public string OccupaidTo { get; set; }
        public bool IsReserved { get; set; }
        public bool IsSelected { get; set; }
        public string Description { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblRoomHome(TblRoomHome roomHome, HttpStatusCode statusEffect)
        {
            id = roomHome.id;
            Name = roomHome.Name;
            MainImage = roomHome.MainImage;
            ClientId = roomHome.ClientId;
            CityId = roomHome.CityId;
            PriceNormal = roomHome.PriceNormal;
            PriceWeekend = roomHome.PriceWeekend;
            DaysOccupaid = roomHome.DaysOccupaid;
            OccupaidFrom = roomHome.OccupaidFrom;
            OccupaidTo = roomHome.OccupaidTo;
            IsReserved = roomHome.IsReserved;
            Description = roomHome.Description;
            IsSelected = roomHome.IsSelected;
            StatusEffect = statusEffect;
        }

        public DtoTblRoomHome()
        {
        }
    }
}