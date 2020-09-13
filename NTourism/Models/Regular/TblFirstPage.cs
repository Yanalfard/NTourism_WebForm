namespace NTourism.Models.Regular
{
    public class TblFirstPage
    {
        public int id { get; set; }
        public string Sign { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public bool IsText { get; set; }

        public TblFirstPage(int id)
        {
            this.id = id;
        }

		public TblFirstPage(int id, string sign, string image, string text, bool isText)
        {
            this.id = id;
            Sign = sign;
            Image = image;
            Text = text;
            IsText = isText;
        }
        public TblFirstPage(string sign, string image, string text, bool isText)
        {
            Sign = sign;
            Image = image;
            Text = text;
            IsText = isText;
        }

        public TblFirstPage()
        {
            
        }
    }
}