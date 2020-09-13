using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class AttractionCommentsRelRepo : IAttractionCommentsRelRepo
    {
        public TblAttractionCommentsRel AddAttractionCommentsRel(TblAttractionCommentsRel AttractionCommentsRel)
        {
            return (TblAttractionCommentsRel)new MainProvider().Add(AttractionCommentsRel);
        }

        public bool DeleteAttractionCommentsRel(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblAttractionCommentsRel, id);
        }

        public bool UpdateAttractionCommentsRel(TblAttractionCommentsRel AttractionCommentsRel, int logId)
        {
            return new MainProvider().Update(AttractionCommentsRel, logId);
        }

        public List<TblAttractionCommentsRel> SelectAllAttractionCommentsRels()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblAttractionCommentsRel).Cast<TblAttractionCommentsRel>().ToList();
        }

        public TblAttractionCommentsRel SelectAttractionCommentsRelById(int id)
        {
            return (TblAttractionCommentsRel)new MainProvider().SelectById(MainProvider.Tables.TblAttractionCommentsRel, id);
        }

        public List<TblAttractionCommentsRel> SelectAttractionCommentsRelByAttractionId(int AttractionId)
        {
            return new MainProvider().SelectAttractionCommentsRel(AttractionId,
                MainProvider.AttractionCommentsRel.AttractionId);
        }

        public List<TblAttractionCommentsRel> SelectAttractionCommentsRelByCommentId(int commentId)
        {
            return new MainProvider().SelectAttractionCommentsRel(commentId,
                MainProvider.AttractionCommentsRel.CommentId);
        }
    }
}