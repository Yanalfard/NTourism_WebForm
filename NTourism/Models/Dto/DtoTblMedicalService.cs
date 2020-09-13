using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblMedicalService
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SicknessName { get; set; }
        public string SicknessDesc { get; set; }
        public string PassNo { get; set; }
        public int PassportImageId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblMedicalService(TblMedicalService medicalService, HttpStatusCode statusEffect)
        {
            id = medicalService.id;
            FirstName = medicalService.FirstName;
            LastName = medicalService.LastName;
            SicknessName = medicalService.SicknessName;
            SicknessDesc = medicalService.SicknessDesc;
            PassNo = medicalService.PassNo;
            PassportImageId = medicalService.PassportImageId;

            StatusEffect = statusEffect;
        }

        public DtoTblMedicalService()
        {
        }
    }
}