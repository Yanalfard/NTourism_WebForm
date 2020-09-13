//---> int id
//---> string Text
//---> int ClientId
//---> bool IsValid
function AddComments(comments)
{
    return Bjax('/api/CommentsCore/AddComments', comments, 'LP');
}
function DeleteComments(id)
{
    return Bjax('/api/CommentsCore/DeleteComments?id=', id, 'SP');
}
function UpdateComments(comments, logId)
{
    var commentsLogId = new Array();
    commentsLogId.push(comments);
    commentsLogId.push(logId);
    return Bjax('/api/CommentsCore/UpdateComments', commentsLogId, 'LP');
}
function SelectAllCommentss()
{
    return Bjax('/api/CommentsCore/SelectAllCommentss', '', 'G');
}
function SelectCommentsById(id)
{
    return Bjax('/api/CommentsCore/SelectCommentsById?id=', id, 'SP');
}
function SelectCommentsByClientId(clientId)
{
    return Bjax('/api/CommentsCore/SelectCommentsByClientId?clientId=', clientId, 'SP');
}
function SelectCommentsByIsValid(isValid)
{
    return Bjax('/api/CommentsCore/SelectCommentsByIsValid?isValid=', isValid, 'SP');
}
