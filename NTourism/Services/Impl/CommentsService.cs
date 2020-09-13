using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class CommentsService : ICommentsService
    {
        public TblComments AddComment(TblComments comment)
        {
            return (TblComments)new CommentsRepo().AddComment(comment);
        }

        public bool DeleteComment(int id)
        {
            return new CommentsRepo().DeleteComment(id);
        }

        public bool UpdateComment(TblComments comment, int logId)
        {
            return new CommentsRepo().UpdateComment(comment, logId);
        }

        public List<TblComments> SelectAllComments()
        {
            return new CommentsRepo().SelectAllComments();
        }

        public TblComments SelectCommentById(int id)
        {
            return new CommentsRepo().SelectCommentById(id);
        }

        public List<TblComments> SelectCommentsByClientId(int clientId)
        {
            return new CommentsRepo().SelectCommentsByClientId(clientId);
        }

        public TblClient SelectClientByComment(int commentId)
        {
            return new ClientRepo().SelectClientById(new CommentsRepo().SelectCommentById(commentId).ClientId);
        }
    }
}