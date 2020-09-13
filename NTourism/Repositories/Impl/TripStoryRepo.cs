using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class TripStoryRepo : ITripStoryRepo
    {
        public TblTripStory AddTripStory(TblTripStory tripStory)
        {
            return (TblTripStory)new MainProvider().Add(tripStory);
        }
        public bool DeleteTripStory(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblTripStory, id);
        }
        public bool UpdateTripStory(TblTripStory tripStory, int logId)
        {
            return new MainProvider().Update(tripStory, logId);
        }
        public List<TblTripStory> SelectAllTripStorys()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblTripStory).Cast<TblTripStory>().ToList();
        }
        public TblTripStory SelectTripStoryById(int id)
        {
            return (TblTripStory)new MainProvider().SelectById(MainProvider.Tables.TblTripStory, id);
        }
        public TblTripStory SelectTripStoryByTitle(string title)
        {
            return new MainProvider().SelectTripStoryByTitle(title);
        }
        public List<TblTripStory> SelectTripStoryByCityId(int cityId)
        {
            return new MainProvider().SelectTripStoryByCityId(cityId);
        }
        public List<TblTripStory> SelectTripStoryByTextId(int textId)
        {
            return new MainProvider().SelectTripStoryByTextId(textId);
        }
        public List<TblTripStory> SelectTripStoryByImageId(int imageId)
        {
            return new MainProvider().SelectTripStoryByimageId(imageId);
        }
    }
}