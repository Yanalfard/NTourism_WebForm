//---> int id
//---> int RoomHomeId
//---> int CommentId
function AddRoomHomeCommentsRel(roomHomeCommentsRel)
{
    return Bjax('/api/RoomHomeCommentsRelCore/AddRoomHomeCommentsRel', roomHomeCommentsRel, 'LP');
}
function DeleteRoomHomeCommentsRel(id)
{
    return Bjax('/api/RoomHomeCommentsRelCore/DeleteRoomHomeCommentsRel?id=', id, 'SP');
}
function UpdateRoomHomeCommentsRel(roomHomeCommentsRel, logId)
{
    var roomHomeCommentsRelLogId = new Array();
    roomHomeCommentsRelLogId.push(roomHomeCommentsRel);
    roomHomeCommentsRelLogId.push(logId);
    return Bjax('/api/RoomHomeCommentsRelCore/UpdateRoomHomeCommentsRel', roomHomeCommentsRelLogId, 'LP');
}
function SelectAllRoomHomeCommentsRels()
{
    return Bjax('/api/RoomHomeCommentsRelCore/SelectAllRoomHomeCommentsRels', '', 'G');
}
function SelectRoomHomeCommentsRelById(id)
{
    return Bjax('/api/RoomHomeCommentsRelCore/SelectRoomHomeCommentsRelById?id=', id, 'SP');
}
function SelectRoomHomeCommentsRelByRoomHomeId(roomHomeId)
{
    return Bjax('/api/RoomHomeCommentsRelCore/roomHomeId?roomHomeId=', roomHomeId, 'SP');
}
function SelectRoomHomeCommentsRelByCommentId(commentId)
{
    return Bjax('/api/RoomHomeCommentsRelCore/commentId?commentId=', commentId, 'SP');
}
