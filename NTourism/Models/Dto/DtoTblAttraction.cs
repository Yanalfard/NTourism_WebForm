using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblAttraction
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public int TextId { get; set; }

        public int ImageId { get; set; }

        public bool IsText { get; set; }

        public int CityId { get; set; }

        public int Score { get; set; }

        public int OrderId { get; set; }

        public int Status { get; set; }

        public bool IsSelected { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblAttraction(TblAttraction Attraction, HttpStatusCode statusEffect)
        {
            id = Attraction.id;
            Name = Attraction.Name;
            Title = Attraction.Title;
            TextId = Attraction.TextId;
            ImageId = Attraction.ImageId;
            IsText = Attraction.IsText;
            CityId = Attraction.CityId;
            Score = Attraction.Score;
            OrderId = Attraction.OrderId;
            Status = Attraction.Status;
            IsSelected = Attraction.IsSelected;

            StatusEffect = statusEffect;
        }

        public DtoTblAttraction()
        {
        }
    }
}