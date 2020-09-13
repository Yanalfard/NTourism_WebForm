using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;
using NTourism.Utilities;

namespace NTourism.Services.Impl
{
    public class AttractionService : IAttractionService
    {
        public TblAttraction AddAttraction(TblAttraction Attraction)
        {
            return (TblAttraction)new AttractionRepo().AddAttraction(Attraction);
        }

        public bool DeleteAttraction(int id)
        {
            return new AttractionRepo().DeleteAttraction(id);
        }

        public bool UpdateAttraction(TblAttraction Attraction, int logId)
        {
            return new AttractionRepo().UpdateAttraction(Attraction, logId);
        }

        public List<TblAttraction> SelectAllAttractions()
        {
            return new AttractionRepo().SelectAllAttractions();
        }

        public List<TblAttraction> SelectAllEvents()
        {
            return new AttractionRepo().SelectAllEvents();
        }

        public List<TblAttraction> SelectAllTripStories()
        {
            return new AttractionRepo().SelectAllTripStories();
        }

        public TblAttraction SelectAttractionById(int id)
        {
            return new AttractionRepo().SelectAttractionById(id);
        }

        public List<TblAttraction> SelectAttractionByName(string name)
        {
            return new AttractionRepo().SelectAttractionByName(name);
        }

        public List<TblAttraction> SelectAttractionByIsSelected(bool isSelected)
        {
            List<TblAttraction> Attractions = new AttractionRepo().SelectAttractionByIsSelected(isSelected);
            MethodRepo.Shuffle(Attractions);
            return Attractions;
        }

        public List<TblAttraction> SelectEventsByIsSelected(bool isSelected)
        {
            List<TblAttraction> events = new AttractionRepo().SelectEventsByIsSelected(isSelected);
            MethodRepo.Shuffle(events);
            return events;
        }

        public List<TblAttraction> SelectTripStoriesByIsSelected(bool isSelected)
        {
            List<TblAttraction> tripStories = new AttractionRepo().SelectTripStoriesByIsSelected(isSelected);
            MethodRepo.Shuffle(tripStories);
            return tripStories;
        }

        public List<TblAttraction> SelectAttractionByCityId(int cityId)
        {
            return new AttractionRepo().SelectAttractionByCityId(cityId);
        }

        public List<TblAttraction> SelectEventsByCityId(int cityId)
        {
            return new AttractionRepo().SelectEventsByCityId(cityId);
        }

        public List<TblAttraction> SelectTripStoriesByIsCityId(int cityId)
        {
            return new AttractionRepo().SelectTripStoriesByIsCityId(cityId);
        }

        public List<TblPoll>SelectPollsByAttraction(int AttractionId)
        {
            List<TblAttractionPollRel> stp1 = new AttractionPollRelRepo().SelectAttractionPollRelByAttractionId(AttractionId);
            List<TblPoll> stp2 = new List<TblPoll>();
            foreach (TblAttractionPollRel rel in stp1)
                stp2.Add(new PollRepo().SelectPollById(rel.id));
            
            return stp2;
        }

        public List<TblComments> SelectCommentsByAttraction(int AttractionId)
        {
            List<TblAttractionCommentsRel> stp1 = new AttractionCommentsRelRepo().SelectAttractionCommentsRelByAttractionId(AttractionId);
            List<TblComments> stp2 = new List<TblComments>();
            foreach (TblAttractionCommentsRel rel in stp1)
                stp2.Add(new CommentsRepo().SelectCommentById(rel.id));

            return stp2;
        }

        public List<TblEquipment>SelectEquipmentsByAttraction(int AttractionId)
        {
            List<TblAttractionEquipmentRel> stp1 = new AttractionEquipmentRelRepo().SelectAttractionEquipmentRelByAttractionId(AttractionId);
            List<TblEquipment> stp2 = new List<TblEquipment>();
            foreach (TblAttractionEquipmentRel rel in stp1)
                stp2.Add(new EquipmentRepo().SelectEquipmentById(rel.id));
            
            return stp2;
        }

        public List<TblAttraction> SelectAAttraction(string name)
        {
            return new AttractionRepo().SelectAttractionByName(name).OrderBy(i => i.OrderId).ToList();
        }

        public List<TblAttraction> SelectAttractionByStatus(int status)
        {
            return new AttractionRepo().SelectAttractionByStatus(status);
        }
    }
}