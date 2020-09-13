using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ITripStoryRepo
    {
        TblTripStory AddTripStory(TblTripStory tripStory);
        bool DeleteTripStory(int id);
        bool UpdateTripStory(TblTripStory tripStory, int logId);
        List<TblTripStory> SelectAllTripStorys();
        TblTripStory SelectTripStoryById(int id);
        TblTripStory SelectTripStoryByTitle(string title);
        List<TblTripStory> SelectTripStoryByCityId(int cityId);
        List<TblTripStory> SelectTripStoryByTextId(int textId);
        List<TblTripStory> SelectTripStoryByImageId(int imageId);

    }
}