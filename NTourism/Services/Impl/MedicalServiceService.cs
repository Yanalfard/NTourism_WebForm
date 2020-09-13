using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class MedicalServiceService : IMedicalServiceService
    {
        public TblMedicalService AddMedicalService(TblMedicalService medicalService)
        {
            return (TblMedicalService)new MedicalServiceRepo().AddMedicalService(medicalService);
        }
        public bool DeleteMedicalService(int id)
        {
            return new MedicalServiceRepo().DeleteMedicalService(id);
        }
        public bool UpdateMedicalService(TblMedicalService medicalService, int logId)
        {
            return new MedicalServiceRepo().UpdateMedicalService(medicalService, logId);
        }
        public List<TblMedicalService> SelectAllMedicalServices()
        {
            return new MedicalServiceRepo().SelectAllMedicalServices();
        }
        public TblMedicalService SelectMedicalServiceById(int id)
        {
            return (TblMedicalService)new MedicalServiceRepo().SelectMedicalServiceById(id);
        }
        public TblMedicalService SelectMedicalServiceByFirstName(string firstName)
        {
            return new MedicalServiceRepo().SelectMedicalServiceByFirstName(firstName);
        }
        public TblMedicalService SelectMedicalServiceByLastName(string lastName)
        {
            return new MedicalServiceRepo().SelectMedicalServiceByLastName(lastName);
        }
        public TblMedicalService SelectMedicalServiceBySicknessName(string sicknessName)
        {
            return new MedicalServiceRepo().SelectMedicalServiceBySicknessName(sicknessName);
        }
        public List<TblMedicalService> SelectMedicalServiceByPassportImageId(int passportImageId)
        {
            return new MedicalServiceRepo().SelectMedicalServiceByPassportImageId(passportImageId);
        }
        public List<TblImages> SelectImagessByMedicalServiceId(int medicalServiceId)
        {
            List<TblMedicalServiceImagesRel> stp1 = new MedicalServiceImagesRelRepo().SelectMedicalServiceImagesRelByMedicalServiceId(medicalServiceId);
            List<TblImages> stp2 = new List<TblImages>();
            foreach (TblMedicalServiceImagesRel rel in stp1)
                stp2.Add(new TblImages(0, rel.Image, "Image"));
            return stp2;
        }

    }
}