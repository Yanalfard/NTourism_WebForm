//---> int id
//---> int AttractionId
//---> int RoomHomeId
//---> int CityId
function AddCityAttractionRel(cityAttractionRel)
{
    return Bjax('/api/CityAttractionRelCore/AddCityAttractionRel', cityAttractionRel, 'LP');
}
function DeleteCityAttractionRel(id)
{
    return Bjax('/api/CityAttractionRelCore/DeleteCityAttractionRel?id=', id, 'SP');
}
function UpdateCityAttractionRel(cityAttractionRel, logId)
{
    var cityAttractionRelLogId = new Array();
    cityAttractionRelLogId.push(cityAttractionRel);
    cityAttractionRelLogId.push(logId);
    return Bjax('/api/CityAttractionRelCore/UpdateCityAttractionRel', cityAttractionRelLogId, 'LP');
}
function SelectAllCityAttractionRels()
{
    return Bjax('/api/CityAttractionRelCore/SelectAllCityAttractionRels', '', 'G');
}
function SelectCityAttractionRelById(id)
{
    return Bjax('/api/CityAttractionRelCore/SelectCityAttractionRelById?id=', id, 'SP');
}
function SelectCityAttractionRelByAttractionId(attractionId)
{
    return Bjax('/api/CityAttractionRelCore/attractionId?attractionId=', attractionId, 'SP');
}
function SelectCityAttractionRelByRoomHomeId(roomHomeId)
{
    return Bjax('/api/CityAttractionRelCore/roomHomeId?roomHomeId=', roomHomeId, 'SP');
}
function SelectCityAttractionRelByCityId(cityId)
{
    return Bjax('/api/CityAttractionRelCore/cityId?cityId=', cityId, 'SP');
}
