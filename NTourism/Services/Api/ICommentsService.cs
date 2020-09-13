using NTourism.Models.Regular;
using NTourism.Repositories.Api;

namespace NTourism.Services.Api
{
    public interface ICommentsService : ICommentsRepo
    {
        TblClient SelectClientByComment(int commentId);
    }
}