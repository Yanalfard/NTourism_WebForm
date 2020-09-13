using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IMedicalServiceRepo
    {
        TblMedicalService AddMedicalService(TblMedicalService medicalService);
        bool DeleteMedicalService(int id);
        bool UpdateMedicalService(TblMedicalService medicalService, int logId);
        List<TblMedicalService> SelectAllMedicalServices();
        TblMedicalService SelectMedicalServiceById(int id);
        TblMedicalService SelectMedicalServiceByFirstName(string firstName);
        TblMedicalService SelectMedicalServiceByLastName(string lastName);
        TblMedicalService SelectMedicalServiceBySicknessName(string sicknessName);
        List<TblMedicalService> SelectMedicalServiceByPassportImageId(int passportImageId);

    }
}