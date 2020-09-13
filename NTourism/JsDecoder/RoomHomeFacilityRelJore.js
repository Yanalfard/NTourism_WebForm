//---> int id
//---> int RoomHomeId
//---> int FacilityId
function AddRoomHomeFacilityRel(roomHomeFacilityRel)
{
    return Bjax('/api/RoomHomeFacilityRelCore/AddRoomHomeFacilityRel', roomHomeFacilityRel, 'LP');
}
function DeleteRoomHomeFacilityRel(id)
{
    return Bjax('/api/RoomHomeFacilityRelCore/DeleteRoomHomeFacilityRel?id=', id, 'SP');
}
function UpdateRoomHomeFacilityRel(roomHomeFacilityRel, logId)
{
    var roomHomeFacilityRelLogId = new Array();
    roomHomeFacilityRelLogId.push(roomHomeFacilityRel);
    roomHomeFacilityRelLogId.push(logId);
    return Bjax('/api/RoomHomeFacilityRelCore/UpdateRoomHomeFacilityRel', roomHomeFacilityRelLogId, 'LP');
}
function SelectAllRoomHomeFacilityRels()
{
    return Bjax('/api/RoomHomeFacilityRelCore/SelectAllRoomHomeFacilityRels', '', 'G');
}
function SelectRoomHomeFacilityRelById(id)
{
    return Bjax('/api/RoomHomeFacilityRelCore/SelectRoomHomeFacilityRelById?id=', id, 'SP');
}
function SelectRoomHomeFacilityRelByRoomHomeId(roomHomeId)
{
    return Bjax('/api/RoomHomeFacilityRelCore/SelectRoomHomeFacilityRelByRoomHomeId?roomHomeId=', roomHomeId, 'SP');
}
function SelectRoomHomeFacilityRelByFacilityId(facilityId)
{
    return Bjax('/api/RoomHomeFacilityRelCore/SelectRoomHomeFacilityRelByFacilityId?facility=', facilityId, 'SP');
}
