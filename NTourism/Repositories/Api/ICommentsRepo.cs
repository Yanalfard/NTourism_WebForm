using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ICommentsRepo
    {
        TblComments AddComment(TblComments comment);
        bool DeleteComment(int id);
        bool UpdateComment(TblComments comment, int logId);
        List<TblComments> SelectAllComments();
        TblComments SelectCommentById(int id);
        List<TblComments> SelectCommentsByClientId(int clientId);

    }
}