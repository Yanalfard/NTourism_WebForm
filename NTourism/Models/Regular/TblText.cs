namespace NTourism.Models.Regular
{
    public class TblText
    {
        public int id { get; set; }

        public string Text { get; set; }

        public string Rtf { get; set; }

        public TblText(int id)
        {
            this.id = id;
        }

        public TblText(string text, string rtf)
        {
            Text = text;
            Rtf = rtf;
        }

        public TblText(int id, string text, string rtf)
        {
            this.id = id;
            Text = text;
            Rtf = rtf;
        }

        public TblText()
        {
        }
    }
}