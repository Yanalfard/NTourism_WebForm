using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;

namespace NTourism.Services.Api
{
    public interface IMedicalServiceService : IMedicalServiceRepo
    {
        List<TblImages>SelectImagessByMedicalServiceId(int medicalServiceId);

    }
}