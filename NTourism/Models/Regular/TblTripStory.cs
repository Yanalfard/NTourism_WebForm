namespace NTourism.Models.Regular
{
    public class TblTripStory
    {
        public int id { get; set; }
        public string Title { get; set; }
        public int CityId { get; set; }
        public string MainImage { get; set; }
        public int TextId { get; set; }
        public int imageId { get; set; }
        public string DatePosted { get; set; }

        public TblTripStory(int id)
        {
            this.id = id;
        }

		public TblTripStory(int id, string title, int cityId, string mainImage, int textId, int imageId, string datePosted)
        {
            this.id = id;
            Title = title;
            CityId = cityId;
            MainImage = mainImage;
            TextId = textId;
            imageId = imageId;
            DatePosted = datePosted;
        }
        public TblTripStory(string title, int cityId, string mainImage, int textId, int imageId, string datePosted)
        {
            Title = title;
            CityId = cityId;
            MainImage = mainImage;
            TextId = textId;
            imageId = imageId;
            DatePosted = datePosted;
        }

        public TblTripStory()
        {
            
        }
    }
}