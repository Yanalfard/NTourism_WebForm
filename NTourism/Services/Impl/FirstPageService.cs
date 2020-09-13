using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class FirstPageService : IFirstPageService
    {
        public TblFirstPage AddFirstPage(TblFirstPage firstPage)
        {
            return (TblFirstPage)new FirstPageRepo().AddFirstPage(firstPage);
        }
        public bool DeleteFirstPage(int id)
        {
            return new FirstPageRepo().DeleteFirstPage(id);
        }
        public bool UpdateFirstPage(TblFirstPage firstPage, int logId)
        {
            return new FirstPageRepo().UpdateFirstPage(firstPage, logId);
        }
        public List<TblFirstPage> SelectAllFirstPages()
        {
            return new FirstPageRepo().SelectAllFirstPages();
        }
        public TblFirstPage SelectFirstPageById(int id)
        {
            return (TblFirstPage)new FirstPageRepo().SelectFirstPageById(id);
        }
        public TblFirstPage SelectFirstPageByImage(string image)
        {
            return new FirstPageRepo().SelectFirstPageByImage(image);
        }
        public List<TblFirstPage> SelectFirstPageByIsText(bool isText)
        {
            return new FirstPageRepo().SelectFirstPageByIsText(isText);
        }

    }
}