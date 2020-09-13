using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IAttractionRepo
    {
        TblAttraction AddAttraction(TblAttraction Attraction);
        bool DeleteAttraction(int id);
        bool UpdateAttraction(TblAttraction Attraction, int logId);
        List<TblAttraction> SelectAllAttractions();
        List<TblAttraction> SelectAllEvents();
        List<TblAttraction> SelectAllTripStories();
        TblAttraction SelectAttractionById(int id);
        List<TblAttraction> SelectAttractionByName(string name);
        List<TblAttraction> SelectAttractionByIsSelected(bool isSelected);
        List<TblAttraction> SelectEventsByIsSelected(bool isSelected);
        List<TblAttraction> SelectTripStoriesByIsSelected(bool isSelected);
        List<TblAttraction> SelectAttractionByCityId(int cityId);
        List<TblAttraction> SelectEventsByCityId(int cityId);
        List<TblAttraction> SelectTripStoriesByIsCityId(int cityId);
        List<TblAttraction> SelectAttractionByStatus(int status);

    }
}