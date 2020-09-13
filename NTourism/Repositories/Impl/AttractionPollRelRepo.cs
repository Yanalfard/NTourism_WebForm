using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class AttractionPollRelRepo : IAttractionPollRelRepo
    {
        public TblAttractionPollRel AddAttractionPollRel(TblAttractionPollRel AttractionPollRel)
        {
            return (TblAttractionPollRel)new MainProvider().Add(AttractionPollRel);
        }
        public bool DeleteAttractionPollRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblAttractionPollRel, id);
        }
        public bool UpdateAttractionPollRel(TblAttractionPollRel AttractionPollRel, int logId)
        {
            return new MainProvider().Update(AttractionPollRel, logId);
        }
        public List<TblAttractionPollRel> SelectAllAttractionPollRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblAttractionPollRel).Cast<TblAttractionPollRel>().ToList();
        }
        public TblAttractionPollRel SelectAttractionPollRelById(int id)
        {
            return (TblAttractionPollRel)new MainProvider().SelectById(MainProvider.Tables.TblAttractionPollRel, id);
        }
        public List<TblAttractionPollRel> SelectAttractionPollRelByAttractionId(int AttractionId)
        {
            return new MainProvider().SelectAttractionPollRel(AttractionId, MainProvider.AttractionPollRel.AttractionId);
        }
        public List<TblAttractionPollRel> SelectAttractionPollRelByPollId(int pollId)
        {
            return new MainProvider().SelectAttractionPollRel(pollId, MainProvider.AttractionPollRel.PollId);
        }

    }
}