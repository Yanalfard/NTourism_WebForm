using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class FacilityRepo: IFacilityRepo
    {
        public TblFacility AddFacility(TblFacility facility)
        {
            return (TblFacility)new MainProvider().Add(facility);
        }

        public bool DeleteFacility(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblFacility, id);
        }

        public bool UpdateFacility(TblFacility facility, int logId)
        {
            return new MainProvider().Update(facility, logId);
        }

        public List<TblFacility> SelectAllFacilities()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblFacility).Cast<TblFacility>().ToList();
        }

        public TblFacility SelectFacilityById(int id)
        {
            return (TblFacility)new MainProvider().SelectById(MainProvider.Tables.TblFacility, id);
        }

        public TblFacility SelectFacilityByName(string name)
        {
            return new MainProvider().SelectFacilityByName(name);
        }
    }
}