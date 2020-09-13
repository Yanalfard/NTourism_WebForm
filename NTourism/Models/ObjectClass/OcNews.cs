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
    public class OcNews : TblNews
    {
        [Display(Name = "Text")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Text { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Select Enter {0}")]
        public string Image { get; set; }
        [Display(Name = "Image Key")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MaxLength(100)]
        public string ImageName { get; set; }
        public OcNews(TblNews news)
        {
            id = news.id;
            Name = news.Name;
            Title = news.Title;
            OrderId = news.OrderId;
            Text = new TextService().SelectTextById(news.TextId).Text;
            Image = new ImagesService().SelectImageById(news.ImageId).Image;
            IsText = news.IsText;
            IsSelected = news.IsSelected;
            MainImage = news.MainImage;
            IsPinned = news.IsPinned;
            IsValid = news.IsValid;
            ImageName = new ImagesService().SelectImageById(news.ImageId).Name;
        }
        public OcNews()
        {

        }
    }
}