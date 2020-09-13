namespace NTourism.Models.Regular
{
    public class TblTourGuideImagesRel
    {
        public int id { get; set; }

        public int TourGuideId { get; set; }

        public int ImageId { get; set; }

        public TblTourGuideImagesRel(int id)
        {
            this.id = id;
        }

        public TblTourGuideImagesRel(int tourGuideId, int imageId)
        {
            TourGuideId = tourGuideId;
            ImageId = imageId;
        }

        public TblTourGuideImagesRel(int id, int tourGuideId, int imageId)
        {
            this.id = id;
            TourGuideId = tourGuideId;
            ImageId = imageId;
        }

        public TblTourGuideImagesRel()
        {
        }
    }
}