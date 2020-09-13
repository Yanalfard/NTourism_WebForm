using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class MedicalServiceImagesRelRepo : IMedicalServiceImagesRelRepo
    {
        public TblMedicalServiceImagesRel AddMedicalServiceImagesRel(TblMedicalServiceImagesRel medicalServiceImagesRel)
        {
            return (TblMedicalServiceImagesRel)new MainProvider().Add(medicalServiceImagesRel);
        }
        public bool DeleteMedicalServiceImagesRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblMedicalServiceImagesRel, id);
        }
        public bool UpdateMedicalServiceImagesRel(TblMedicalServiceImagesRel medicalServiceImagesRel, int logId)
        {
            return new MainProvider().Update(medicalServiceImagesRel, logId);
        }
        public List<TblMedicalServiceImagesRel> SelectAllMedicalServiceImagesRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblMedicalServiceImagesRel).Cast<TblMedicalServiceImagesRel>().ToList();
        }
        public TblMedicalServiceImagesRel SelectMedicalServiceImagesRelById(int id)
        {
            return (TblMedicalServiceImagesRel)new MainProvider().SelectById(MainProvider.Tables.TblMedicalServiceImagesRel, id);
        }
        public List<TblMedicalServiceImagesRel> SelectMedicalServiceImagesRelByMedicalServiceId(int medicalServiceId)
        {
            return new MainProvider().SelectMedicalServiceImagesRel(medicalServiceId, MainProvider.MedicalServiceImagesRel.MedicalServiceId);
        }
        public List<TblMedicalServiceImagesRel> SelectMedicalServiceImagesRelByImageId(int imageId)
        {
            return new MainProvider().SelectMedicalServiceImagesRel(imageId, MainProvider.MedicalServiceImagesRel.ImageId);
        }

    }
}