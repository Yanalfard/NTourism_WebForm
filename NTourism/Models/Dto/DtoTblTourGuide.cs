using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblTourGuide
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TellNo { get; set; }

        public string Email { get; set; }

        public string MainImage { get; set; }

        public string Description { get; set; }

        public int CityId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Rate { get; set; }

        public int Discount { get; set; }

        public int Price { get; set; }


        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblTourGuide(TblTourGuide tourGuide, HttpStatusCode statusEffect)
        {
            id = tourGuide.id;
            FirstName = tourGuide.FirstName;
            LastName = tourGuide.LastName;
            TellNo = tourGuide.TellNo;
            Email = tourGuide.Email;
            MainImage = tourGuide.MainImage;
            Description = tourGuide.Description;
            CityId = tourGuide.CityId;
            Username = tourGuide.Username;
            Password = tourGuide.Password;
            StatusEffect = statusEffect;
            Rate = tourGuide.Rate;
            Discount = tourGuide.Discount;
            Price = tourGuide.Price;
        }

        public DtoTblTourGuide()
        {
        }
    }
}