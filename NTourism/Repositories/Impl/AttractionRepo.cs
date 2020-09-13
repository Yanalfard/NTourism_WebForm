using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class AttractionRepo : IAttractionRepo
    {
        public TblAttraction AddAttraction(TblAttraction Attraction)
        {
            return (TblAttraction)new MainProvider().Add(Attraction);
        }

        public bool DeleteAttraction(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblAttraction, id);
        }

        public bool UpdateAttraction(TblAttraction Attraction, int logId)
        {
            return new MainProvider().Update(Attraction, logId);
        }

        public List<TblAttraction> SelectAllAttractions()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblAttraction).Cast<TblAttraction>().ToList();
        }

        public List<TblAttraction> SelectAllEvents()
        {
            return new MainProvider().SelectAllEvents();
        }

        public List<TblAttraction> SelectAllTripStories()
        {
            return new MainProvider().SelectAllTripStories();
        }

        public TblAttraction SelectAttractionById(int id)
        {
            return (TblAttraction)new MainProvider().SelectById(MainProvider.Tables.TblAttraction, id);
        }

        public List<TblAttraction> SelectAttractionByName(string name)
        {
            return new MainProvider().SelectAttractionByName(name);
        }

        public List<TblAttraction> SelectAttractionByIsSelected(bool isSelected)
        {
            return new MainProvider().SelectAttractionByIsSelected(isSelected);
        }

        public List<TblAttraction> SelectEventsByIsSelected(bool isSelected)
        {
            return new MainProvider().SelectEventsByIsSelected(isSelected);
        }

        public List<TblAttraction> SelectTripStoriesByIsSelected(bool isSelected)
        {
            return new MainProvider().SelectTripStoriesByIsSelected(isSelected);
        }

        public List<TblAttraction> SelectAttractionByCityId(int cityId)
        {
            return new MainProvider().SelectAttractionByCityId(cityId);
        }

        public List<TblAttraction> SelectEventsByCityId(int cityId)
        {
            return new MainProvider().SelectEventsByCityId(cityId);
        }

        public List<TblAttraction> SelectTripStoriesByIsCityId(int cityId)
        {
            return new MainProvider().SelectTripStoriesByIsCityId(cityId);
        }

        public List<TblAttraction> SelectAttractionByStatus(int status)
        {
            return new MainProvider().SelectAttractionByStatus(status);
        }
    }
}