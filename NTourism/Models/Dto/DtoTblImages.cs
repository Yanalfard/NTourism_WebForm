using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblImages
    {
        public int id { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblImages(TblImages image, HttpStatusCode statusEffect)
        {
            id = image.id;
            Image = image.Image;
            Name = image.Name;
            StatusEffect = statusEffect;
        }

        public DtoTblImages()
        {
        }
    }
}