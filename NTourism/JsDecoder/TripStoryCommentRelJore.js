//---> int id
//---> int TripStoryId
//---> int CommentId
function AddTripStoryCommentRel(tripStoryCommentRel)
{
    return Bjax('/api/TripStoryCommentRelCore/AddTripStoryCommentRel', tripStoryCommentRel, 'LP');
}
function DeleteTripStoryCommentRel(id)
{
    return Bjax('/api/TripStoryCommentRelCore/DeleteTripStoryCommentRel?id=', id, 'SP');
}
function UpdateTripStoryCommentRel(tripStoryCommentRel, logId)
{
    var tripStoryCommentRelLogId = new Array();
    tripStoryCommentRelLogId.push(tripStoryCommentRel);
    tripStoryCommentRelLogId.push(logId);
    return Bjax('/api/TripStoryCommentRelCore/UpdateTripStoryCommentRel', tripStoryCommentRelLogId, 'LP');
}
function SelectAllTripStoryCommentRels()
{
    return Bjax('/api/TripStoryCommentRelCore/SelectAllTripStoryCommentRels', '', 'G');
}
function SelectTripStoryCommentRelById(id)
{
    return Bjax('/api/TripStoryCommentRelCore/SelectTripStoryCommentRelById?id=', id, 'SP');
}
function SelectTripStoryCommentRelByTripStoryId(tripStoryId)
{
    return Bjax('/api/TripStoryCommentRelCore/tripStoryId?tripStoryId=', tripStoryId, 'SP');
}
function SelectTripStoryCommentRelByCommentId(commentId)
{
    return Bjax('/api/TripStoryCommentRelCore/commentId?commentId=', commentId, 'SP');
}
