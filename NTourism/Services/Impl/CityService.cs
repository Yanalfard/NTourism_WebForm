using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class CityService : ICityService
    {
        public TblCity AddCity(TblCity city)
        {
            return (TblCity)new CityRepo().AddCity(city);
        }

        public bool DeleteCity(int id)
        {
            return new CityRepo().DeleteCity(id);
        }

        public bool UpdateCity(TblCity city, int logId)
        {
            return new CityRepo().UpdateCity(city, logId);
        }

        public List<TblCity> SelectAllCities()
        {
            return new CityRepo().SelectAllCities();
        }

        public TblCity SelectCityById(int id)
        {
            return new CityRepo().SelectCityById(id);
        }

        public List<TblCity> SelectCityByCountryId(int countryId)
        {
            return new CityRepo().SelectCityByCountryId(countryId);
        }

        public TblCity SelectCityByName(string name)
        {
            return new CityRepo().SelectCityByName(name);
        }
        public List<TblAttraction> SelectAttractionsByCityId(int cityId)
        {
            List<TblCityAttractionRel> stp1 = new CityAttractionRelRepo().SelectCityAttractionRelByCityId(cityId);
            List<TblAttraction> stp2 = new List<TblAttraction>();
            foreach (TblCityAttractionRel rel in stp1)
                stp2.Add(new AttractionRepo().SelectAttractionById(rel.AttractionId));
            return stp2;
        }
    }
}