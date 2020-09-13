namespace NTourism.Models.Regular
{
    public class TblImages
    {
        public int id { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public TblImages(int id)
        {
            this.id = id;
        }

        public TblImages(string image, string name)
        {
            Image = image;
            Name = name;
        }

        public TblImages(int id, string image, string name)
        {
            this.id = id;
            Image = image;
            Name = name;
        }

        public TblImages()
        {
        }
    }
}