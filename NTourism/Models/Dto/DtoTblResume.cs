using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblResume
    {
        public int id { get; set; }

        public string Name { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblResume(TblResume resume, HttpStatusCode statusEffect)
        {
            id = resume.id;
            Name = resume.Name;
            StatusEffect = statusEffect;
        }

        public DtoTblResume()
        {
        }
    }
}