using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;
using NTourism.Utilities;

namespace NTourism.Services.Impl
{
    public class NewsService : INewsService
    {
        public TblNews AddNews(TblNews news)
        {
            return (TblNews)new NewsRepo().AddNews(news);
        }

        public bool DeleteNews(int id)
        {
            return new NewsRepo().DeleteNews(id);
        }

        public bool UpdateNews(TblNews news, int logId)
        {
            return new NewsRepo().UpdateNews(news, logId);
        }

        public List<TblNews> SelectAllNews()
        {
            return new NewsRepo().SelectAllNews().Where(i => i.IsSelected).ToList();
        }

        public TblNews SelectNewsById(int id)
        {
            return new NewsRepo().SelectNewsById(id);
        }

        public List<TblNews> SelectNewsByName(string name)
        {
            return new NewsRepo().SelectNewsByName(name);
        }

        public List<TblNews> SelectNewsByOrder(string name)
        {
            return new NewsRepo().SelectNewsByOrder(name);
        }

        public List<TblNews> SelectNewsByTextId(int textId)
        {
            return new NewsRepo().SelectNewsByTextId(textId);
        }

        public List<TblNews> SelectNewsByImageId(int imageId)
        {
            return new NewsRepo().SelectNewsByImageId(imageId);
        }

        public List<TblNews> SelectNewsByIsSelected(bool isSelected)
        {
            List<TblNews> news = new NewsRepo().SelectNewsByIsSelected(isSelected);
            MethodRepo.Shuffle(news);
            return news;
        }

        public List<TblNews> SelectANews(string name)
        {
            return new NewsRepo().SelectNewsByName(name).OrderBy(i => i.OrderId).ToList();
        }

        public List<TblNews> SelectTopRandomNews(int count)
        {
            return new NewsRepo().SelectTopRandomNews(count);
        }
    }
}