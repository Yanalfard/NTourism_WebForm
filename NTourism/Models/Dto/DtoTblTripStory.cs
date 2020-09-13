using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblTripStory
    {
        public int id { get; set; }
        public string Title { get; set; }
        public int CityId { get; set; }
        public string MainImage { get; set; }
        public int TextId { get; set; }
        public int imageId { get; set; }
        public string DatePosted { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblTripStory(TblTripStory tripStory, HttpStatusCode statusEffect)
        {
            id = tripStory.id;
            Title = tripStory.Title;
            CityId = tripStory.CityId;
            MainImage = tripStory.MainImage;
            TextId = tripStory.TextId;
            imageId = tripStory.imageId;
            DatePosted = tripStory.DatePosted;

            StatusEffect = statusEffect;
        }

        public DtoTblTripStory()
        {
        }
    }
}