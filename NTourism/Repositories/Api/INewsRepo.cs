using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface INewsRepo
    {
        TblNews AddNews(TblNews news);
        bool DeleteNews(int id);
        bool UpdateNews(TblNews news, int logId);
        List<TblNews> SelectAllNews();
        TblNews SelectNewsById(int id);
        List<TblNews> SelectNewsByName(string name);
        List<TblNews> SelectNewsByOrder(string name);
        List<TblNews> SelectNewsByTextId(int textId);
        List<TblNews> SelectNewsByImageId(int imageId);
        List<TblNews> SelectNewsByIsSelected(bool isSelected);
        List<TblNews> SelectTopRandomNews(int count);

    }
}