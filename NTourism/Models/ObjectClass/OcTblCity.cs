using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NTourism.Models.Regular;
using NTourism.Services.Impl;
namespace NTourism.Models.ObjectClass
{
    public class OcTblCity : TblCity
    {
        public string Country { get; set; }
        public OcTblCity()
        {

        }
        public OcTblCity(TblCity city)
        {
            id = city.id;
            Name = city.Name;
            Country = new CountryService().SelectCountryById(city.CountryId).Name;
            MapLink = city.MapLink;
            Data = city.Data;
            MainImage = city.MainImage;
            IsValid = city.IsValid;
        }
    }
}