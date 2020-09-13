using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class TextRepo: ITextRepo

    {
        public TblText AddText(TblText text)
        {
            return (TblText)new MainProvider().Add(text);
        }

        public bool DeleteText(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblText, id);
        }

        public bool UpdateText(TblText text, int logId)
        {
            return new MainProvider().Update(text, logId);
        }

        public List<TblText> SelectAllTexts()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblText).Cast<TblText>().ToList();
        }

        public TblText SelectTextById(int id)
        {
            return (TblText)new MainProvider().SelectById(MainProvider.Tables.TblText, id);
        }
    }
}