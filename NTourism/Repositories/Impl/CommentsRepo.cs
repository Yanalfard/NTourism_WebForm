using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class CommentsRepo: ICommentsRepo
    {
        public TblComments AddComment(TblComments comment)
        {
            return (TblComments)new MainProvider().Add(comment);
        }

        public bool DeleteComment(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblComments, id);
        }

        public bool UpdateComment(TblComments comment, int logId)
        {
            return new MainProvider().Update(comment, logId);
        }

        public List<TblComments> SelectAllComments()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblComments).Cast<TblComments>().ToList();
        }

        public TblComments SelectCommentById(int id)
        {
            return (TblComments) new MainProvider().SelectById(MainProvider.Tables.TblComments, id);
        }

        public List<TblComments> SelectCommentsByClientId(int clientId)
        {
            return new MainProvider().SelectCommentsByClientId(clientId);
        }
    }
}