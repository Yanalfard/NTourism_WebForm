using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class AttractionCommentsRelService : IAttractionCommentsRelService
    {
        public TblAttractionCommentsRel AddAttractionCommentsRel(TblAttractionCommentsRel AttractionCommentsRel)
        {
            return (TblAttractionCommentsRel)new AttractionCommentsRelRepo().AddAttractionCommentsRel(AttractionCommentsRel);
        }

        public bool DeleteAttractionCommentsRel(int id)
        {
            return new AttractionCommentsRelRepo().DeleteAttractionCommentsRel(id);
        }

        public bool UpdateAttractionCommentsRel(TblAttractionCommentsRel AttractionCommentsRel, int logId)
        {
            return new AttractionCommentsRelRepo().UpdateAttractionCommentsRel(AttractionCommentsRel, logId);
        }

        public List<TblAttractionCommentsRel> SelectAllAttractionCommentsRels()
        {
            return new AttractionCommentsRelRepo().SelectAllAttractionCommentsRels();
        }

        public TblAttractionCommentsRel SelectAttractionCommentsRelById(int id)
        {
            return new AttractionCommentsRelRepo().SelectAttractionCommentsRelById(id);
        }

        public List<TblAttractionCommentsRel> SelectAttractionCommentsRelByAttractionId(int AttractionId)
        {
            return new AttractionCommentsRelRepo().SelectAttractionCommentsRelByAttractionId(AttractionId);
        }

        public List<TblAttractionCommentsRel> SelectAttractionCommentsRelByCommentId(int commentId)
        {
            return new AttractionCommentsRelRepo().SelectAttractionCommentsRelByCommentId(commentId);
        }
    }
}