using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class TourGuideService : ITourGuideService
    {
        public TblTourGuide AddTourGuide(TblTourGuide tourGuide)
        {
            return (TblTourGuide)new TourGuideRepo().AddTourGuide(tourGuide);
        }

        public bool DeleteTourGuide(int id)
        {
            return new TourGuideRepo().DeleteTourGuide(id);
        }

        public bool UpdateTourGuide(TblTourGuide tourGuide, int logId)
        {
            return new TourGuideRepo().UpdateTourGuide(tourGuide, logId);
        }

        public List<TblTourGuide> SelectAllTourGuides()
        {
            return new TourGuideRepo().SelectAllTourGuides();
        }

        public TblTourGuide SelectTourGuideById(int id)
        {
            return new TourGuideRepo().SelectTourGuideById(id);
        }

        public TblTourGuide SelectTourGuideByTellNo(string tellNo)
        {
            return new TourGuideRepo().SelectTourGuideByTellNo(tellNo);
        }

        public TblTourGuide SelectTourGuideByEmail(string email)
        {
            return new TourGuideRepo().SelectTourGuideByEmail(email);
        }

        public TblTourGuide SelectTourGuideByUsername(string username)
        {
            return new TourGuideRepo().SelectTourGuideByUsername(username);
        }

        public List<TblEquipment> SelectEquipmentsByTourGuide(int tourGuideId)
        {
            List<TblTourGuideEquipmentRel> stp1 = new TourGuideEquipmentRelRepo().SelectTourGuideEquipmentRelByTourGuideId(tourGuideId);
            List<TblEquipment> stp2 = new List<TblEquipment>();
            foreach (TblTourGuideEquipmentRel rel in stp1)
                stp2.Add(new EquipmentRepo().SelectEquipmentById(rel.id));

            return stp2;
        }

        public List<TblImages> SelectImagesByTourGuide(int tourGuideId)
        {
            List<TblTourGuideImagesRel> stp1 = new TourGuideImagesRelRepo().SelectTourGuideImagesRelByTourGuideId(tourGuideId);
            List<TblImages> stp2 = new List<TblImages>();
            foreach (TblTourGuideImagesRel rel in stp1)
                stp2.Add(new ImagesRepo().SelectImageById(rel.ImageId));

            return stp2;
        }

        public List<TblResume> SelectResumesByTourGuide(int tourGuideId)
        {
            List<TblTourGuideResumeRel> stp1 = new TourGuideResumeRelRepo().SelectTourGuideResumeRelByTourGuideId(tourGuideId);
            List<TblResume> stp2 = new List<TblResume>();
            foreach (TblTourGuideResumeRel rel in stp1)
                stp2.Add(new ResumeRepo().SelectResumeById(rel.id));

            return stp2;
        }

        public List<TblTourGuide> SelectTourGuideByCityId(int cityId)
        {
            return new TourGuideRepo().SelectTourGuideByCityId(cityId);
        }

        public List<TblTourGuide> SelectTourGuideByDiscount(int cityId)
        {
            return new TourGuideRepo().SelectTourGuideByDiscount(cityId);
        }
    }
}