using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ITextRepo
    {
        TblText AddText(TblText text);
        bool DeleteText(int id);
        bool UpdateText(TblText text, int logId);
        List<TblText> SelectAllTexts();
        TblText SelectTextById(int id);

    }
}