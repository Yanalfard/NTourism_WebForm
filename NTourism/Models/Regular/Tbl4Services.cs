using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NTourism.Models.Regular;
using NTourism.Services.Impl;
namespace NTourism.Models.Regular
{
    public class Tbl4Services
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Select Enter {0}")]
        [Display(Name = "Title")]
        [MaxLength(150)]
        public string Title { get; set; }
        [Display(Name = "Text")]
        [Required(ErrorMessage = "Select Enter {0}")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Text { get; set; }
        public int Status { get; set; }

        public Tbl4Services(string title, string text, int status)
        {
            Title = title;
            Text = text;
            Status = status;
        }

        public Tbl4Services(int id)
        {
            this.id = id;
        }

        public Tbl4Services()
        {
        }

        public Tbl4Services(int id, string title, string text, int status)
        {
            this.id = id;
            Title = title;
            Text = text;
            Status = status;
        }
    }
}