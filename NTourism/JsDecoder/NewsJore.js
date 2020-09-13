//---> int id
//---> string Name
//---> string Title
//---> int OrderId
//---> int TextId
//---> int ImageId
//---> bool IsText
//---> bool IsSelected
function AddNews(news)
{
    return Bjax('/api/NewsCore/AddNews', news, 'LP');
}
function DeleteNews(id)
{
    return Bjax('/api/NewsCore/DeleteNews?id=', id, 'SP');
}
function UpdateNews(news, logId)
{
    var newsLogId = new Array();
    newsLogId.push(news);
    newsLogId.push(logId);
    return Bjax('/api/NewsCore/UpdateNews', newsLogId, 'LP');
}
function SelectAllNewss()
{
    return Bjax('/api/NewsCore/SelectAllNews', '', 'G');
}
function SelectNewsById(id)
{
    return Bjax('/api/NewsCore/SelectNewsById?id=', id, 'SP');
}
function SelectNewsByName(name)
{
    return Bjax('/api/NewsCore/SelectNewsByName?name=', name, 'SP');
}
function SelectNewsByTitle(title)
{
    return Bjax('/api/NewsCore/SelectNewsByTitle?title=', title, 'SP');
}
function SelectNewsByOrderId(orderId)
{
    return Bjax('/api/NewsCore/SelectNewsByOrderId?orderId=', orderId, 'SP');
}
function SelectNewsByTextId(textId)
{
    return Bjax('/api/NewsCore/SelectNewsByTextId?textId=', textId, 'SP');
}
function SelectNewsByImageId(imageId)
{
    return Bjax('/api/NewsCore/SelectNewsByImageId?imageId=', imageId, 'SP');
}
function SelectNewsByIsText(isText)
{
    return Bjax('/api/NewsCore/SelectNewsByIsText?isText=', isText, 'SP');
}
function SelectNewsByIsSelected(isSelected)
{
    return Bjax('/api/NewsCore/SelectNewsByIsSelected?isSelected=', isSelected, 'SP');
}
