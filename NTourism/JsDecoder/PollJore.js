//---> int id
//---> string Name
//---> int Vote
function AddPoll(poll)
{
    return Bjax('/api/PollCore/AddPoll', poll, 'LP');
}
function DeletePoll(id)
{
    return Bjax('/api/PollCore/DeletePoll?id=', id, 'SP');
}
function UpdatePoll(poll, logId)
{
    var pollLogId = new Array();
    pollLogId.push(poll);
    pollLogId.push(logId);
    return Bjax('/api/PollCore/UpdatePoll', pollLogId, 'LP');
}
function SelectAllPolls()
{
    return Bjax('/api/PollCore/SelectAllPolls', '', 'G');
}
function SelectPollById(id)
{
    return Bjax('/api/PollCore/SelectPollById?id=', id, 'SP');
}
function SelectPollByName(name)
{
    return Bjax('/api/PollCore/SelectPollByName?name=', name, 'SP');
}
