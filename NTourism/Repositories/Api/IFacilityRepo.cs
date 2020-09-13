using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IFacilityRepo
    {
        TblFacility AddFacility(TblFacility facility);
        bool DeleteFacility(int id);
        bool UpdateFacility(TblFacility facility, int logId);
        List<TblFacility> SelectAllFacilities();
        TblFacility SelectFacilityById(int id);
        TblFacility SelectFacilityByName(string name);


    }
}