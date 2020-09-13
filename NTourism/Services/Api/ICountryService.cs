using NTourism.Models.Regular;
using NTourism.Repositories.Api;

namespace NTourism.Services.Api
{
    public interface ICountryService : ICountryRepo
    {
        TblCountry SelectCountryByCity(int cityId);
    }
}