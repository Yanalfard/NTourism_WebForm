using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IAttractionCommentsRelRepo
    {
        TblAttractionCommentsRel AddAttractionCommentsRel(TblAttractionCommentsRel AttractionCommentsRel);
        bool DeleteAttractionCommentsRel(int id);
        bool UpdateAttractionCommentsRel(TblAttractionCommentsRel AttractionCommentsRel, int logId);
        List<TblAttractionCommentsRel> SelectAllAttractionCommentsRels();
        TblAttractionCommentsRel SelectAttractionCommentsRelById(int id);
        List<TblAttractionCommentsRel> SelectAttractionCommentsRelByAttractionId(int AttractionId);
        List<TblAttractionCommentsRel> SelectAttractionCommentsRelByCommentId(int commentId);

    }
}