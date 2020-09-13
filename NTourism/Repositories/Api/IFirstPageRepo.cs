using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface IFirstPageRepo
    {
        TblFirstPage AddFirstPage(TblFirstPage firstPage);
        bool DeleteFirstPage(int id);
        bool UpdateFirstPage(TblFirstPage firstPage, int logId);
        List<TblFirstPage> SelectAllFirstPages();
        TblFirstPage SelectFirstPageById(int id);
        TblFirstPage SelectFirstPageByImage(string image);
        List<TblFirstPage> SelectFirstPageByIsText(bool isText);

    }
}