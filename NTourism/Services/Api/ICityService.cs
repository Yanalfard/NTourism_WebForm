using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using System.Collections.Generic;

namespace NTourism.Services.Api
{
    public interface ICityService : ICityRepo
    {
        List<TblAttraction> SelectAttractionsByCityId(int cityId);
    }
}