using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class MedicalServiceImagesRelService : IMedicalServiceImagesRelService
    {
        public TblMedicalServiceImagesRel AddMedicalServiceImagesRel(TblMedicalServiceImagesRel medicalServiceImagesRel)
        {
            return (TblMedicalServiceImagesRel)new MedicalServiceImagesRelRepo().AddMedicalServiceImagesRel(medicalServiceImagesRel);
        }
        public bool DeleteMedicalServiceImagesRel(int id)
        {
            return new MedicalServiceImagesRelRepo().DeleteMedicalServiceImagesRel(id);
        }
        public bool UpdateMedicalServiceImagesRel(TblMedicalServiceImagesRel medicalServiceImagesRel, int logId)
        {
            return new MedicalServiceImagesRelRepo().UpdateMedicalServiceImagesRel(medicalServiceImagesRel, logId);
        }
        public List<TblMedicalServiceImagesRel> SelectAllMedicalServiceImagesRels()
        {
            return new MedicalServiceImagesRelRepo().SelectAllMedicalServiceImagesRels();
        }
        public TblMedicalServiceImagesRel SelectMedicalServiceImagesRelById(int id)
        {
            return (TblMedicalServiceImagesRel)new MedicalServiceImagesRelRepo().SelectMedicalServiceImagesRelById(id);
        }
        public List<TblMedicalServiceImagesRel> SelectMedicalServiceImagesRelByMedicalServiceId(int medicalServiceId)
        {
            return new MedicalServiceImagesRelRepo().SelectMedicalServiceImagesRelByMedicalServiceId(medicalServiceId);
        }
        public List<TblMedicalServiceImagesRel> SelectMedicalServiceImagesRelByImageId(int imageId)
        {
            return new MedicalServiceImagesRelRepo().SelectMedicalServiceImagesRelByImageId(imageId);
        }

    }
}