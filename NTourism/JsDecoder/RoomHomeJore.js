//---> int id
//---> string Name
//---> string MainImage
//---> int ClientId
//---> int CityId
//---> long PriceNormal
//---> long PriceWeekend
//---> int DaysOccupaid
//---> string OccupaidFrom
//---> string OccupaidTo
//---> bool IsReserved
//---> string Description
//---> bool IsSelected
function AddRoomHome(roomHome)
{
    return Bjax('/api/RoomHomeCore/AddRoomHome', roomHome, 'LP');
}
function DeleteRoomHome(id)
{
    return Bjax('/api/RoomHomeCore/DeleteRoomHome?id=', id, 'SP');
}
function UpdateRoomHome(roomHome, logId)
{
    var roomHomeLogId = new Array();
    roomHomeLogId.push(roomHome);
    roomHomeLogId.push(logId);
    return Bjax('/api/RoomHomeCore/UpdateRoomHome', roomHomeLogId, 'LP');
}
function SelectAllRoomHomes()
{
    return Bjax('/api/RoomHomeCore/SelectAllRoomHomes', '', 'G');
}
function SelectRoomHomeById(id)
{
    return Bjax('/api/RoomHomeCore/SelectRoomHomeById?id=', id, 'SP');
}
function SelectRoomHomeByName(name)
{
    return Bjax('/api/RoomHomeCore/SelectRoomHomeByName?name=', name, 'SP');
}
function SelectRoomHomeByClientId(clientId)
{
    return Bjax('/api/RoomHomeCore/SelectRoomHomeByClientId?clientId=', clientId, 'SP');
}
function SelectRoomHomeByCityId(cityId)
{
    return Bjax('/api/RoomHomeCore/SelectRoomHomeByCityId?cityId=', cityId, 'SP');
}
function SelectRoomHomeByIsReserved(isReserved)
{
    return Bjax('/api/RoomHomeCore/SelectRoomHomeByIsReserved?isReserved=', isReserved, 'SP');
}
function SelectRoomHomeByIsSelected(isSelected)
{
    return Bjax('/api/RoomHomeCore/SelectRoomHomeByIsSelected?isSelected=', isSelected, 'SP');
}

function SelectFacilitiesByRoomHome(roomHomeId)
{
    return Bjax('/api/RoomHomeCore/SelectFacilitiesByRoomHome?roomHomeId=', roomHomeId, 'SP');
}

function SelectImagesByRoomHome(roomHomeId)
{
    return Bjax('/api/RoomHomeCore/SelectImagesByRoomHome?roomHomeId=', roomHomeId, 'SP');
}

function SelectCommentsByRoomHome(roomHomeId)
{
    return Bjax('/api/RoomHomeCore/SelectCommentsByRoomHome?roomHomeId=', roomHomeId, 'SP');
}