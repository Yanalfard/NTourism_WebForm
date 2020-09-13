using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IMedicalServiceImagesRelRepo
    {
        TblMedicalServiceImagesRel AddMedicalServiceImagesRel(TblMedicalServiceImagesRel medicalServiceImagesRel);
        bool DeleteMedicalServiceImagesRel(int id);
        bool UpdateMedicalServiceImagesRel(TblMedicalServiceImagesRel medicalServiceImagesRel, int logId);
        List<TblMedicalServiceImagesRel> SelectAllMedicalServiceImagesRels();
        TblMedicalServiceImagesRel SelectMedicalServiceImagesRelById(int id);
        List<TblMedicalServiceImagesRel> SelectMedicalServiceImagesRelByMedicalServiceId(int medicalServiceId);
        List<TblMedicalServiceImagesRel> SelectMedicalServiceImagesRelByImageId(int imageId);

    }
}