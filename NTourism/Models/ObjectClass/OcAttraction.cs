using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NTourism.Models.Regular;
using NTourism.Services.Impl;

namespace NTourism.Models.ObjectClass
{
    public class OcAttraction : TblAttraction
    {

        public string City { get; set; }
        [Display(Name = "Text")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [AllowHtml]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        public string Image { get; set; }
        [Display(Name = "ImageName")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MaxLength(100)]
        public string ImageName { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public OcAttraction()
        {

        }

        public OcAttraction(TblAttraction attraction, string from, string to)
        {
            id = attraction.id;
            Name = attraction.Name;
            Title = attraction.Title;
            Text = new TextService().SelectTextById(attraction.TextId).Text;
            Image = new ImagesService().SelectImageById(attraction.ImageId).Image;
            IsText = attraction.IsText;
            City = new CityService().SelectCityById(attraction.CityId).Name;
            Score = attraction.Score;
            OrderId = attraction.OrderId;
            Status = attraction.Status;
            IsSelected = attraction.IsSelected;
            ImageName = new ImagesService().SelectImageById(attraction.ImageId).Name;
            From = from;
            To = to;
        }
    }
}