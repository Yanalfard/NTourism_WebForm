using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;

namespace NTourism.Services.Api
{
    public interface ITripStoryService : ITripStoryRepo
    {
        List<TblComments>SelectCommentsByTripStory(int tripStoryId);

    }
}