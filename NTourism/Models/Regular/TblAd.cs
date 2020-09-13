namespace NTourism.Models.Regular
{
    public class TblAd
    {
        public int id { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public string PositionId { get; set; }
        public bool IsAvailable { get; set; }

        public TblAd(int id)
        {
            this.id = id;
        }

		public TblAd(int id, string image, string link, string positionId, bool isAvailable)
        {
            this.id = id;
            Image = image;
            Link = link;
            PositionId = positionId;
            IsAvailable = isAvailable;
        }
        public TblAd(string image, string link, string positionId, bool isAvailable)
        {
            Image = image;
            Link = link;
            PositionId = positionId;
            IsAvailable = isAvailable;
        }

        public TblAd()
        {
            
        }
    }
}