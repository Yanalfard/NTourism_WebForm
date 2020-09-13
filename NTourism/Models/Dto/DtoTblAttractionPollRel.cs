using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblAttractionPollRel
    {
        public int id { get; set; }
        public int AttractionId { get; set; }
        public int PollId { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblAttractionPollRel(TblAttractionPollRel AttractionPollRel, HttpStatusCode statusEffect)
        {
            id = AttractionPollRel.id;
            AttractionId = AttractionPollRel.AttractionId;
            PollId = AttractionPollRel.PollId;

            StatusEffect = statusEffect;
        }

        public DtoTblAttractionPollRel()
        {
        }
    }
}