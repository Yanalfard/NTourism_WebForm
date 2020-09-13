using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblTourGuideResumeRel
    {
        public int id { get; set; }

        public int TourGuideId { get; set; }

        public int ResumeId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblTourGuideResumeRel(TblTourGuideResumeRel tourGuideResumeRel, HttpStatusCode statusEffect)
        {
            id = tourGuideResumeRel.id;
            TourGuideId = tourGuideResumeRel.TourGuideId;
            ResumeId = tourGuideResumeRel.ResumeId;
            StatusEffect = statusEffect;
        }

        public DtoTblTourGuideResumeRel()
        {
        }
    }
}