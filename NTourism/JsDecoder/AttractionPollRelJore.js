//---> int id
//---> int AttractionId
//---> int PollId

function AddAttractionPollRel(AttractionPollRel)
{
    return Bjax('/api/AttractionPollRelCore/AddAttractionPollRel', AttractionPollRel, 'LP');
}

function DeleteAttractionPollRel(id)
{
    return Bjax('/api/AttractionPollRelCore/DeleteAttractionPollRel?id=', id, 'SP');
}

function UpdateAttractionPollRel(AttractionPollRel, logId)
{
    var AttractionPollRelLogId = new Array();
    AttractionPollRelLogId.push(AttractionPollRel);
    AttractionPollRelLogId.push(logId);
    return Bjax('/api/AttractionPollRelCore/UpdateAttractionPollRel', AttractionPollRelLogId, 'LP');
}

function SelectAllAttractionPollRels()
{
    return Bjax('/api/AttractionPollRelCore/SelectAllAttractionPollRels', '', 'G');
}

function SelectAttractionPollRelById(id)
{
    return Bjax('/api/AttractionPollRelCore/SelectAttractionPollRelById?id=', id, 'SP');
}

function SelectAttractionPollRelByAttractionId(AttractionId)
{
    return Bjax('/api/AttractionPollRelCore/AttractionId?AttractionId=', AttractionId, 'SP');
}

function SelectAttractionPollRelByPollId(pollId)
{
    return Bjax('/api/AttractionPollRelCore/pollId?pollId=', pollId, 'SP');
}

