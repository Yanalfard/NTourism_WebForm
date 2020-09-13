using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblText
    {
        public int id { get; set; }

        public string Text { get; set; }

        public string Rtf { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblText(TblText text, HttpStatusCode statusEffect)
        {
            id = text.id;
            Text = text.Text;
            Rtf = text.Rtf;
            StatusEffect = statusEffect;
        }

        public DtoTblText()
        {
        }
    }
}