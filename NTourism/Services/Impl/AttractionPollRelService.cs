using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class AttractionPollRelService : IAttractionPollRelService
    {
        public TblAttractionPollRel AddAttractionPollRel(TblAttractionPollRel AttractionPollRel)
        {
            return (TblAttractionPollRel)new AttractionPollRelRepo().AddAttractionPollRel(AttractionPollRel);
        }
        public bool DeleteAttractionPollRel(int id)
        {
            return new AttractionPollRelRepo().DeleteAttractionPollRel(id);
        }
        public bool UpdateAttractionPollRel(TblAttractionPollRel AttractionPollRel, int logId)
        {
            return new AttractionPollRelRepo().UpdateAttractionPollRel(AttractionPollRel, logId);
        }
        public List<TblAttractionPollRel> SelectAllAttractionPollRels()
        {
            return new AttractionPollRelRepo().SelectAllAttractionPollRels();
        }
        public TblAttractionPollRel SelectAttractionPollRelById(int id)
        {
            return (TblAttractionPollRel)new AttractionPollRelRepo().SelectAttractionPollRelById(id);
        }
        public List<TblAttractionPollRel> SelectAttractionPollRelByAttractionId(int AttractionId)
        {
            return new AttractionPollRelRepo().SelectAttractionPollRelByAttractionId(AttractionId);
        }
        public List<TblAttractionPollRel> SelectAttractionPollRelByPollId(int pollId)
        {
            return new AttractionPollRelRepo().SelectAttractionPollRelByPollId(pollId);
        }

    }
}