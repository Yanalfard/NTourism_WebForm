using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class CityRepo: ICityRepo
    {
        public TblCity AddCity(TblCity city)
        {
            return (TblCity)new MainProvider().Add(city);
        }

        public bool DeleteCity(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblCity, id);
        }

        public bool UpdateCity(TblCity city, int logId)
        {
            return new MainProvider().Update(city, logId);
        }

        public List<TblCity> SelectAllCities()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblCity).Cast<TblCity>().ToList();
        }

        public TblCity SelectCityById(int id)
        {
            return (TblCity)new MainProvider().SelectById(MainProvider.Tables.TblCity, id);
        }

        public List<TblCity> SelectCityByCountryId(int countryId)
        {
            return new MainProvider().SelectCityByCountryId(countryId);
        }

        public TblCity SelectCityByName(string name)
        {
            return new MainProvider().SelectCityByName(name);
        }
    }
}