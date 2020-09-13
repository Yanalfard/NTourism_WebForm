using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblFirstPage
    {
        public int id { get; set; }
        public string Sign { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public bool IsText { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public TblFirstPage ToRegular()
        {
            return new TblFirstPage(id, Sign, Image, Text, IsText);
        }

        public DtoTblFirstPage(TblFirstPage firstPage, HttpStatusCode statusEffect)
        {
            id = firstPage.id;
            Sign = firstPage.Sign;
            Image = firstPage.Image;
            Text = firstPage.Text;
            IsText = firstPage.IsText;

            StatusEffect = statusEffect;
        }

        public DtoTblFirstPage()
        {
        }
    }
}