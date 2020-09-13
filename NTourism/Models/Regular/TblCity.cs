using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace NTourism.Models.Regular
{
    public class TblCity
    {
        public int id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MaxLength(50)]
        public string Name { get; set; }

        public int CountryId { get; set; }
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Data { get; set; }
        [DataType(DataType.MultilineText)]
        public string MapLink { get; set; }

        public string MainImage { get; set; }

        public bool IsValid { get; set; }

        public TblCity(int id)
        {
            this.id = id;
        }

        public TblCity(string name, int countryId, string data, string mapLink, string mainImage, bool isValid)
        {
            Name = name;
            CountryId = countryId;
            Data = data;
            MapLink = mapLink;
            MainImage = mainImage;
            IsValid = isValid;
        }

        public TblCity(int id, string name, int countryId, string data, string mapLink, string mainImage, bool isValid)
        {
            this.id = id;
            Name = name;
            CountryId = countryId;
            Data = data;
            MapLink = mapLink;
            MainImage = mainImage;
            IsValid = isValid;
        }

        public TblCity()
        {
        }
    }
}