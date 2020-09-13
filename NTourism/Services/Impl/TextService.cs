using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class TextService : ITextService
    {
        public TblText AddText(TblText text)
        {
            return (TblText)new TextRepo().AddText(text);
        }

        public bool DeleteText(int id)
        {
            return new TextRepo().DeleteText(id);
        }

        public bool UpdateText(TblText text, int logId)
        {
            return new TextRepo().UpdateText(text, logId);
        }

        public List<TblText> SelectAllTexts()
        {
            return new TextRepo().SelectAllTexts();
        }

        public TblText SelectTextById(int id)
        {
            return new TextRepo().SelectTextById(id);
        }
    }
}