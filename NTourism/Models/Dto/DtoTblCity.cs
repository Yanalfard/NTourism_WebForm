using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblCity
    {
        public int id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public string Data { get; set; }

        public string MapLink { get; set; }//VIM

        public string MainImage { get; set; }

        public bool IsValid { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblCity(TblCity city, HttpStatusCode statusEffect)
        {
            id = city.id;
            Name = city.Name;
            CountryId = city.CountryId;
            StatusEffect = statusEffect;
            Data = city.Data;
            MapLink = city.MapLink;
            MainImage = city.MainImage;
            IsValid = city.IsValid;
        }

        public DtoTblCity()
        {
        }
    }
}