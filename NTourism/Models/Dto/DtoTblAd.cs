using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblAd
    {
        public int id { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public string PositionId { get; set; }
        public bool IsAvailable { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblAd(TblAd ad, HttpStatusCode statusEffect)
        {
            id = ad.id;
            Image = ad.Image;
            Link = ad.Link;
            PositionId = ad.PositionId;
            IsAvailable = ad.IsAvailable;

            StatusEffect = statusEffect;
        }

        public DtoTblAd()
        {
        }
    }
}