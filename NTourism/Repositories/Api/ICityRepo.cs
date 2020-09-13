using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ICityRepo
    {
        TblCity AddCity(TblCity city);
        bool DeleteCity(int id);
        bool UpdateCity(TblCity city, int logId);
        List<TblCity> SelectAllCities();
        TblCity SelectCityById(int id);
        List<TblCity> SelectCityByCountryId(int countryId);
        TblCity SelectCityByName(string name);

    }
}