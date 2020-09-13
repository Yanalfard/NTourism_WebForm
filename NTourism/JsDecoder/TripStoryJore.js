//---> int id
//---> string Title
//---> int CityId
//---> string MainImage
//---> int TextId
//---> int imageId
//---> string DatePosted
function AddTripStory(tripStory)
{
    return Bjax('/api/TripStoryCore/AddTripStory', tripStory, 'LP');
}
function DeleteTripStory(id)
{
    return Bjax('/api/TripStoryCore/DeleteTripStory?id=', id, 'SP');
}
function UpdateTripStory(tripStory, logId)
{
    var tripStoryLogId = new Array();
    tripStoryLogId.push(tripStory);
    tripStoryLogId.push(logId);
    return Bjax('/api/TripStoryCore/UpdateTripStory', tripStoryLogId, 'LP');
}
function SelectAllTripStorys()
{
    return Bjax('/api/TripStoryCore/SelectAllTripStorys', '', 'G');
}
function SelectTripStoryById(id)
{
    return Bjax('/api/TripStoryCore/SelectTripStoryById?id=', id, 'SP');
}
function SelectTripStoryByTitle(title)
{
    return Bjax('/api/TripStoryCore/SelectTripStoryByTitle?title=', title, 'SP');
}
function SelectTripStoryByCityId(cityId)
{
    return Bjax('/api/TripStoryCore/SelectTripStoryByCityId?cityId=', cityId, 'SP');
}
function SelectTripStoryByTextId(textId)
{
    return Bjax('/api/TripStoryCore/SelectTripStoryByTextId?textId=', textId, 'SP');
}
function SelectTripStoryByimageId(imageId)
{
    return Bjax('/api/TripStoryCore/SelectTripStoryByimageId?imageId=', imageId, 'SP');
}
