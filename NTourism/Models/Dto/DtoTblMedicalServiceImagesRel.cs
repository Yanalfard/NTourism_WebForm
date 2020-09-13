using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblMedicalServiceImagesRel
    {
        public int id { get; set; }
        public int MedicalServiceId { get; set; }
        public string Image { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblMedicalServiceImagesRel(TblMedicalServiceImagesRel medicalServiceImagesRel, HttpStatusCode statusEffect)
        {
            id = medicalServiceImagesRel.id;
            MedicalServiceId = medicalServiceImagesRel.MedicalServiceId;
            Image = medicalServiceImagesRel.Image;

            StatusEffect = statusEffect;
        }

        public DtoTblMedicalServiceImagesRel()
        {
        }
    }
}