using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class FirstPageRepo : IFirstPageRepo
    {
        public TblFirstPage AddFirstPage(TblFirstPage firstPage)
        {
            return (TblFirstPage)new MainProvider().Add(firstPage);
        }
        public bool DeleteFirstPage(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblFirstPage, id);
        }
        public bool UpdateFirstPage(TblFirstPage firstPage, int logId)
        {
            return new MainProvider().Update(firstPage, logId);
        }
        public List<TblFirstPage> SelectAllFirstPages()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblFirstPage).Cast<TblFirstPage>().ToList();
        }
        public TblFirstPage SelectFirstPageById(int id)
        {
            return (TblFirstPage)new MainProvider().SelectById(MainProvider.Tables.TblFirstPage, id);
        }
        public TblFirstPage SelectFirstPageByImage(string image)
        {
            return new MainProvider().SelectFirstPageByImage(image);
        }
        public List<TblFirstPage> SelectFirstPageByIsText(bool isText)
        {
            return new MainProvider().SelectFirstPageByIsText(isText);
        }

    }
}