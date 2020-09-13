//---> int id
//---> int AttractionId
//---> int CommentId

function AddAttractionCommentsRel(AttractionCommentsRel)
{
    return Bjax('/api/AttractionCommentsRelCore/AddAttractionCommentsRel', AttractionCommentsRel, 'LP');
}

function DeleteAttractionCommentsRel(id)
{
    return Bjax('/api/AttractionCommentsRelCore/DeleteAttractionCommentsRel?id=', id, 'SP');
}

function UpdateAttractionCommentsRel(AttractionCommentsRel, logId)
{
    var AttractionCommentsRelLogId = new Array();
    AttractionCommentsRelLogId.push(AttractionCommentsRel);
    AttractionCommentsRelLogId.push(logId);
    return Bjax('/api/AttractionCommentsRelCore/UpdateAttractionCommentsRel', AttractionCommentsRelLogId, 'LP');
}

function SelectAllAttractionCommentsRels()
{
    return Bjax('/api/AttractionCommentsRelCore/SelectAllAttractionCommentsRels', '', 'G');
}

function SelectAttractionCommentsRelById(id)
{
    return Bjax('/api/AttractionCommentsRelCore/SelectAttractionCommentsRelById?id=', id, 'SP');
}

function SelectAttractionCommentsRelByAttractionId(AttractionId)
{
    return Bjax('/api/AttractionCommentsRelCore/AttractionId?AttractionId=', AttractionId, 'SP');
}

function SelectAttractionCommentsRelByCommentId(commentId)
{
    return Bjax('/api/AttractionCommentsRelCore/commentId?commentId=', commentId, 'SP');
}

