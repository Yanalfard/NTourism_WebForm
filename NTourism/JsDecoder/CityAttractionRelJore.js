//---> int id
//---> int AttractionId
//---> int RoomHomeId
//---> int CityId

{
    return Bjax('/api/CityAttractionRelCore/AddCityAttractionRel', cityAttractionRel, 'LP');
}

{
    return Bjax('/api/CityAttractionRelCore/DeleteCityAttractionRel?id=', id, 'SP');
}

{
    var cityAttractionRelLogId = new Array();
    cityAttractionRelLogId.push(cityAttractionRel);
    cityAttractionRelLogId.push(logId);
    return Bjax('/api/CityAttractionRelCore/UpdateCityAttractionRel', cityAttractionRelLogId, 'LP');
}

{
    return Bjax('/api/CityAttractionRelCore/SelectAllCityAttractionRels', '', 'G');
}

{
    return Bjax('/api/CityAttractionRelCore/SelectCityAttractionRelById?id=', id, 'SP');
}

{
    return Bjax('/api/CityAttractionRelCore/attractionId?attractionId=', attractionId, 'SP');
}

{
    return Bjax('/api/CityAttractionRelCore/roomHomeId?roomHomeId=', roomHomeId, 'SP');
}

{
    return Bjax('/api/CityAttractionRelCore/cityId?cityId=', cityId, 'SP');
}
