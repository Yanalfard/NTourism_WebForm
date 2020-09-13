namespace NTourism.Models.Regular
{
    public class TblComments
    {
        public int id { get; set; }

        public string Text { get; set; }

        public int ClientId { get; set; }

        public bool IsValid { get; set; }

        public TblComments(int id)
        {
            this.id = id;
        }

        public TblComments(string text, int clientId, bool isValid)
        {
            Text = text;
            ClientId = clientId;
            IsValid = isValid;
        }

        public TblComments(int id, string text, int clientId, bool isValid)
        {
            this.id = id;
            Text = text;
            ClientId = clientId;
            IsValid = isValid;
        }

        public TblComments()
        {
        }
    }
}