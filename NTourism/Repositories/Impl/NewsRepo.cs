using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class NewsRepo: INewsRepo

    {
        public TblNews AddNews(TblNews news)
        {
            return (TblNews)new MainProvider().Add(news);
        }

        public bool DeleteNews(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblNews, id);
        }

        public bool UpdateNews(TblNews news, int logId)
        {
            return new MainProvider().Update(news, logId);
        }

        public List<TblNews> SelectAllNews()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblNews).Cast<TblNews>().ToList();
        }

        public TblNews SelectNewsById(int id)
        {
            return (TblNews)new MainProvider().SelectById(MainProvider.Tables.TblNews, id);
        }

        public List<TblNews> SelectNewsByName(string name)
        {
            return new MainProvider().SelectNewsByName(name);
        }

        public List<TblNews> SelectNewsByOrder(string name)
        {
            return new MainProvider().SelectNewsByOrder(name);
        }

        public List<TblNews> SelectNewsByTextId(int textId)
        {
            return new MainProvider().SelectNewsByTextId(textId);
        }

        public List<TblNews> SelectNewsByImageId(int imageId)
        {
            return new MainProvider().SelectNewsByImageId(imageId);
        }

        public List<TblNews> SelectNewsByIsSelected(bool isSelected)
        {
            return new MainProvider().SelectNewsByIsSelected(isSelected);
        }

        public List<TblNews> SelectTopRandomNews(int count)
        {
            return new MainProvider().SelectTopRandomNews(count);
        }
    }
}