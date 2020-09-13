using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblAttractionCommentsRel
    {
        public int id { get; set; }

        public int AttractionId { get; set; }

        public int CommentId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblAttractionCommentsRel(TblAttractionCommentsRel AttractionCommentsRel, HttpStatusCode statusEffect)
        {
            id = AttractionCommentsRel.id;
            AttractionId = AttractionCommentsRel.AttractionId;
            CommentId = AttractionCommentsRel.CommentId;
            StatusEffect = statusEffect;
        }

        public DtoTblAttractionCommentsRel()
        {
        }
    }
}