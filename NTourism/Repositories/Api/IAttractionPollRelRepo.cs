using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IAttractionPollRelRepo
    {
        TblAttractionPollRel AddAttractionPollRel(TblAttractionPollRel AttractionPollRel);
        bool DeleteAttractionPollRel(int id);
        bool UpdateAttractionPollRel(TblAttractionPollRel AttractionPollRel, int logId);
        List<TblAttractionPollRel> SelectAllAttractionPollRels();
        TblAttractionPollRel SelectAttractionPollRelById(int id);
        List<TblAttractionPollRel> SelectAttractionPollRelByAttractionId(int AttractionId);
        List<TblAttractionPollRel> SelectAttractionPollRelByPollId(int pollId);

    }
}