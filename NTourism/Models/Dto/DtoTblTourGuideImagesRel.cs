using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblTourGuideImagesRel
    {
        public int id { get; set; }

        public int TourGuideId { get; set; }

        public int ImageId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblTourGuideImagesRel(TblTourGuideImagesRel tourGuideImagesRel, HttpStatusCode statusEffect)
        {
            id = tourGuideImagesRel.id;
            TourGuideId = tourGuideImagesRel.TourGuideId;
            ImageId = tourGuideImagesRel.ImageId;
            StatusEffect = statusEffect;
        }

        public DtoTblTourGuideImagesRel()
        {
        }
    }
}