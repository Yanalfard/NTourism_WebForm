//---> int id
//---> string Name
//---> int Vote

{
    return Bjax('/api/PollCore/AddPoll', poll, 'LP');
}

{
    return Bjax('/api/PollCore/DeletePoll?id=', id, 'SP');
}

{
    var pollLogId = new Array();
    pollLogId.push(poll);
    pollLogId.push(logId);
    return Bjax('/api/PollCore/UpdatePoll', pollLogId, 'LP');
}

{
    return Bjax('/api/PollCore/SelectAllPolls', '', 'G');
}

{
    return Bjax('/api/PollCore/SelectPollById?id=', id, 'SP');
}

{
    return Bjax('/api/PollCore/SelectPollByName?name=', name, 'SP');
}
