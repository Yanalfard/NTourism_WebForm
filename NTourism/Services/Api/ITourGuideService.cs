using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;

namespace NTourism.Services.Api
{
    public interface ITourGuideService : ITourGuideRepo
    {
        List<TblEquipment> SelectEquipmentsByTourGuide(int tourGuideId);
        List<TblImages> SelectImagesByTourGuide(int tourGuideId);
        List<TblResume> SelectResumesByTourGuide(int tourGuideId);
    }
}