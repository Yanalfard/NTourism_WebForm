//---> int id
//---> string Name
//---> string Title
//---> int TextId
//---> int ImageId
//---> bool IsText
//---> int CityId
//---> int Score
//---> int OrderId
//---> int Status
//---> string Let
//---> string Lun
//---> bool IsSelected

function AddAttraction(Attraction)
{
    return Bjax('/api/AttractionCore/AddAttraction', Attraction, 'LP');
}

function DeleteAttraction(id)
{
    return Bjax('/api/AttractionCore/DeleteAttraction?id=', id, 'SP');
}

function UpdateAttraction(Attraction, logId)
{
    var AttractionLogId = new Array();
    AttractionLogId.push(Attraction);
    AttractionLogId.push(logId);
    return Bjax('/api/AttractionCore/UpdateAttraction', AttractionLogId, 'LP');
}

function SelectAllAttractions()
{
    return Bjax('/api/AttractionCore/SelectAllAttractions', '', 'G');
}

function SelectAttractionById(id)
{
    return Bjax('/api/AttractionCore/SelectAttractionById?id=', id, 'SP');
}

function SelectAttractionByName(name)
{
    return Bjax('/api/AttractionCore/SelectAttractionByName?name=', name, 'SP');
}

function SelectAttractionByTitle(title)
{
    return Bjax('/api/AttractionCore/SelectAttractionByTitle?title=', title, 'SP');
}

function SelectAttractionByTextId(textId)
{
    return Bjax('/api/AttractionCore/SelectAttractionByTextId?textId=', textId, 'SP');
}

function SelectAttractionByImageId(imageId)
{
    return Bjax('/api/AttractionCore/SelectAttractionByImageId?imageId=', imageId, 'SP');
}

function SelectAttractionByIsText(isText)
{
    return Bjax('/api/AttractionCore/SelectAttractionByIsText?isText=', isText, 'SP');
}

function SelectAttractionByCityId(cityId)
{
    return Bjax('/api/AttractionCore/SelectAttractionByCityId?cityId=', cityId, 'SP');
}

function SelectAttractionByOrderId(orderId)
{
    return Bjax('/api/AttractionCore/SelectAttractionByOrderId?orderId=', orderId, 'SP');
}

function SelectAttractionByIsSelected(isSelected)
{
    return Bjax('/api/AttractionCore/SelectAttractionByIsSelected?isSelected=', isSelected, 'SP');
}

function SelectEventsByCityId(cityId)
{
    return Bjax('/api/AttractionCore/SelectEventsByCityId?cityId=', cityId, 'SP');
}

function SelectTripStoriesByCityId(cityId)
{
    return Bjax('/api/AttractionCore/SelectTripStoriesByCityId?cityId=', cityId, 'SP');
}

function SelectAAttraction(name)
{
    return Bjax('/api/AttractionCore/SelectAAttraction?name=', name, 'SP');
}

function SelectAttractionByStatus(status)
{
    return Bjax('/api/AttractionCore/SelectAttractionByStatus?status=', status, 'SP');
}