using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class FacilityService : IFacilityService
    {
        public TblFacility AddFacility(TblFacility facility)
        {
            return (TblFacility)new FacilityRepo().AddFacility(facility);
        }

        public bool DeleteFacility(int id)
        {
            return new FacilityRepo().DeleteFacility(id);
        }

        public bool UpdateFacility(TblFacility facility, int logId)
        {
            return new FacilityRepo().UpdateFacility(facility, logId);
        }

        public List<TblFacility> SelectAllFacilities()
        {
            return new FacilityRepo().SelectAllFacilities();
        }

        public TblFacility SelectFacilityById(int id)
        {
            return new FacilityRepo().SelectFacilityById(id);
        }

        public TblFacility SelectFacilityByName(string name)
        {
            return new FacilityRepo().SelectFacilityByName(name);
        }
    }
}