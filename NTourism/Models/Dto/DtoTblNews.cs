using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblNews
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public int OrderId { get; set; }

        public int TextId { get; set; }

        public int ImageId { get; set; }

        public bool IsText { get; set; }

        public string MainImage { get; set; }

        public bool IsValid { get; set; }

        public bool IsPinned { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblNews(TblNews news, HttpStatusCode statusEffect)
        {
            id = news.id;
            Name = news.Name;
            Title = news.Title;
            OrderId = news.OrderId;
            TextId = news.TextId;
            ImageId = news.ImageId;
            IsText = news.IsText;
            MainImage = news.MainImage;
            IsValid = news.IsValid;
            IsPinned = news.IsPinned;
            StatusEffect = statusEffect;
        }

        public DtoTblNews()
        {
        }
    }
}