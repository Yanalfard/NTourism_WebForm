using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class CountryService : ICountryService
    {
        public TblCountry AddCountry(TblCountry country)
        {
            return (TblCountry)new CountryRepo().AddCountry(country);
        }

        public bool DeleteCountry(int id)
        {
            return new CountryRepo().DeleteCountry(id);
        }

        public bool UpdateCountry(TblCountry country, int logId)
        {
            return new CountryRepo().UpdateCountry(country, logId);
        }

        public List<TblCountry> SelectAllCountries()
        {
            return new CountryRepo().SelectAllCountries();
        }

        public TblCountry SelectCountryById(int id)
        {
            return new CountryRepo().SelectCountryById(id);
        }

        public TblCountry SelectCountryByName(string name)
        {
            return new CountryRepo().SelectCountryByName(name);
        }

        public TblCountry SelectCountryByCity(int cityId)
        {
            return new CountryRepo().SelectCountryById(cityId);
        }
    }
}