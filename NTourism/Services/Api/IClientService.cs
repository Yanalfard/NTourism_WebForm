using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;

namespace NTourism.Services.Api
{
    public interface IClientService : IClientRepo
    {
        List<TblComments> SelectCommentsByClientId(int clientId);
    }
}