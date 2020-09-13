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
    public class TblCountry
    {
        public int id { get; set; }
        [Display(Name = "Country Name")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MaxLength(50)]
        public string Name { get; set; }

        public TblCountry(int id)
        {
            this.id = id;
        }

        public TblCountry(string name)
        {
            Name = name;
        }

        public TblCountry(int id, string name)
        {
            this.id = id;
            Name = name;
        }

        public TblCountry()
        {
        }
    }
}