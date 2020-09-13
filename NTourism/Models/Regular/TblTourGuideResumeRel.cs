namespace NTourism.Models.Regular
{
    public class TblTourGuideResumeRel
    {
        public int id { get; set; }

        public int TourGuideId { get; set; }

        public int ResumeId { get; set; }

        public TblTourGuideResumeRel(int id)
        {
            this.id = id;
        }

        public TblTourGuideResumeRel(int tourGuideId, int resumeId)
        {
            TourGuideId = tourGuideId;
            ResumeId = resumeId;
        }

        public TblTourGuideResumeRel(int id, int tourGuideId, int resumeId)
        {
            this.id = id;
            TourGuideId = tourGuideId;
            ResumeId = resumeId;
        }

        public TblTourGuideResumeRel()
        {
        }
    }
}