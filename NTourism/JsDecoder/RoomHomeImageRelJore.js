//---> int id
//---> int RoomHomeId
//---> int ImageId
function AddRoomHomeImageRel(roomHomeImageRel)
{
    return Bjax('/api/RoomHomeImageRelCore/AddRoomHomeImageRel', roomHomeImageRel, 'LP');
}
function DeleteRoomHomeImageRel(id)
{
    return Bjax('/api/RoomHomeImageRelCore/DeleteRoomHomeImageRel?id=', id, 'SP');
}
function UpdateRoomHomeImageRel(roomHomeImageRel, logId)
{
    var roomHomeImageRelLogId = new Array();
    roomHomeImageRelLogId.push(roomHomeImageRel);
    roomHomeImageRelLogId.push(logId);
    return Bjax('/api/RoomHomeImageRelCore/UpdateRoomHomeImageRel', roomHomeImageRelLogId, 'LP');
}
function SelectAllRoomHomeImageRels()
{
    return Bjax('/api/RoomHomeImageRelCore/SelectAllRoomHomeImageRels', '', 'G');
}
function SelectRoomHomeImageRelById(id)
{
    return Bjax('/api/RoomHomeImageRelCore/SelectRoomHomeImageRelById?id=', id, 'SP');
}
function SelectRoomHomeImageRelByRoomHomeId(roomHomeId)
{
    return Bjax('/api/RoomHomeImageRelCore/roomHomeId?roomHomeId=', roomHomeId, 'SP');
}
function SelectRoomHomeImageRelByImageId(imageId)
{
    return Bjax('/api/RoomHomeImageRelCore/imageId?imageId=', imageId, 'SP');
}
