using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;

namespace NTourism.Services.Api
{
    public interface IAttractionService : IAttractionRepo
    {
        List<TblPoll>SelectPollsByAttraction(int AttractionId);

        List<TblComments> SelectCommentsByAttraction(int AttractionId);

        List<TblEquipment>SelectEquipmentsByAttraction(int AttractionId);

        List<TblAttraction> SelectAAttraction(string name);
    }
}