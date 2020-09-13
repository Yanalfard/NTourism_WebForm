using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ICountryRepo
    {
        TblCountry AddCountry(TblCountry country);
        bool DeleteCountry(int id);
        bool UpdateCountry(TblCountry country, int logId);
        List<TblCountry> SelectAllCountries();
        TblCountry SelectCountryById(int id);
        TblCountry SelectCountryByName(string name);

    }
}