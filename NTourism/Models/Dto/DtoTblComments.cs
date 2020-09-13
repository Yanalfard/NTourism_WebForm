using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblComments
    {
        public int id { get; set; }

        public string Text { get; set; }

        public int ClientId { get; set; }

        public bool IsValid { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblComments(TblComments comments, HttpStatusCode statusEffect)
        {
            id = comments.id;
            Text = comments.Text;
            ClientId = comments.ClientId;
            IsValid = comments.IsValid;
            StatusEffect = statusEffect;
        }

        public DtoTblComments()
        {
        }
    }
}