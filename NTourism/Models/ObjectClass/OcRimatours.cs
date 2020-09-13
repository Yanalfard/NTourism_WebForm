using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NTourism.Models.Regular;
using NTourism.Services.Impl;

namespace NTourism.Models.ObjectClass
{
    public class OcRimatours : TblTourGuide
    {
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Images")]
        public List<string> Images { get; set; }
        public List<int> ImagesId { get; set; }
        [MaxLength(100)]
        public List<string> ImagesName { get; set; }
        public OcRimatours()
        {

        }
        public OcRimatours(TblTourGuide tourGuide)
        {
            id = tourGuide.id;
            FirstName = tourGuide.FirstName;
            LastName = tourGuide.LastName;
            TellNo = tourGuide.TellNo;
            Email = tourGuide.Email;
            MainImage = tourGuide.MainImage;
            Description = tourGuide.Description;
            Username = tourGuide.Username;
            Password = tourGuide.Password;
            Rate = tourGuide.Rate;
            Discount = tourGuide.Discount;
            Price = tourGuide.Price;

            City = new CityService().SelectCityById(tourGuide.CityId).Name;
            List<TblImages> imagesFromDb = new TourGuideService().SelectImagesByTourGuide(tourGuide.id);
            if (imagesFromDb != null)
            {
                Images = new List<string>();
                ImagesName = new List<string>();
                foreach (TblImages image in imagesFromDb)
                {
                    Images.Add(image.Image);
                    ImagesName.Add(image.Name);

                }
                ImagesId = new List<int>();
                foreach (TblImages imageId in imagesFromDb)
                {
                    ImagesId.Add(imageId.id);

                }
            }
        }
    }
}