using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class MedicalServiceRepo : IMedicalServiceRepo
    {
        public TblMedicalService AddMedicalService(TblMedicalService medicalService)
        {
            return (TblMedicalService)new MainProvider().Add(medicalService);
        }
        public bool DeleteMedicalService(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblMedicalService, id);
        }
        public bool UpdateMedicalService(TblMedicalService medicalService, int logId)
        {
            return new MainProvider().Update(medicalService, logId);
        }
        public List<TblMedicalService> SelectAllMedicalServices()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblMedicalService).Cast<TblMedicalService>().ToList();
        }
        public TblMedicalService SelectMedicalServiceById(int id)
        {
            return (TblMedicalService)new MainProvider().SelectById(MainProvider.Tables.TblMedicalService, id);
        }
        public TblMedicalService SelectMedicalServiceByFirstName(string firstName)
        {
            return new MainProvider().SelectMedicalServiceByFirstName(firstName);
        }
        public TblMedicalService SelectMedicalServiceByLastName(string lastName)
        {
            return new MainProvider().SelectMedicalServiceByLastName(lastName);
        }
        public TblMedicalService SelectMedicalServiceBySicknessName(string sicknessName)
        {
            return new MainProvider().SelectMedicalServiceBySicknessName(sicknessName);
        }
        public List<TblMedicalService> SelectMedicalServiceByPassportImageId(int passportImageId)
        {
            return new MainProvider().SelectMedicalServiceByPassportImageId(passportImageId);
        }

    }
}