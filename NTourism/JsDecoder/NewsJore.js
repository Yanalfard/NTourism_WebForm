//---> int id
//---> string Name
//---> string Title
//---> int OrderId
//---> int TextId
//---> int ImageId
//---> bool IsText
//---> bool IsSelected

{
    return Bjax('/api/NewsCore/AddNews', news, 'LP');
}

{
    return Bjax('/api/NewsCore/DeleteNews?id=', id, 'SP');
}

{
    var newsLogId = new Array();
    newsLogId.push(news);
    newsLogId.push(logId);
    return Bjax('/api/NewsCore/UpdateNews', newsLogId, 'LP');
}

{
    return Bjax('/api/NewsCore/SelectAllNews', '', 'G');
}

{
    return Bjax('/api/NewsCore/SelectNewsById?id=', id, 'SP');
}

{
    return Bjax('/api/NewsCore/SelectNewsByName?name=', name, 'SP');
}

{
    return Bjax('/api/NewsCore/SelectNewsByTitle?title=', title, 'SP');
}

{
    return Bjax('/api/NewsCore/SelectNewsByOrderId?orderId=', orderId, 'SP');
}

{
    return Bjax('/api/NewsCore/SelectNewsByTextId?textId=', textId, 'SP');
}

{
    return Bjax('/api/NewsCore/SelectNewsByImageId?imageId=', imageId, 'SP');
}

{
    return Bjax('/api/NewsCore/SelectNewsByIsText?isText=', isText, 'SP');
}

{
    return Bjax('/api/NewsCore/SelectNewsByIsSelected?isSelected=', isSelected, 'SP');
}
