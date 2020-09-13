//---> int id
//---> int TripStoryId
//---> int CommentId

{
    return Bjax('/api/TripStoryCommentRelCore/AddTripStoryCommentRel', tripStoryCommentRel, 'LP');
}

{
    return Bjax('/api/TripStoryCommentRelCore/DeleteTripStoryCommentRel?id=', id, 'SP');
}

{
    var tripStoryCommentRelLogId = new Array();
    tripStoryCommentRelLogId.push(tripStoryCommentRel);
    tripStoryCommentRelLogId.push(logId);
    return Bjax('/api/TripStoryCommentRelCore/UpdateTripStoryCommentRel', tripStoryCommentRelLogId, 'LP');
}

{
    return Bjax('/api/TripStoryCommentRelCore/SelectAllTripStoryCommentRels', '', 'G');
}

{
    return Bjax('/api/TripStoryCommentRelCore/SelectTripStoryCommentRelById?id=', id, 'SP');
}

{
    return Bjax('/api/TripStoryCommentRelCore/tripStoryId?tripStoryId=', tripStoryId, 'SP');
}

{
    return Bjax('/api/TripStoryCommentRelCore/commentId?commentId=', commentId, 'SP');
}
