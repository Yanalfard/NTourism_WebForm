//---> int id
//---> string FirstName
//---> string LastName
//---> string TellNo
//---> string Email
//---> string Username
//---> string Password
//---> int Status

{
    return Bjax('/api/ClientCore/AddClient', client, 'LP');
}

{
    return Bjax('/api/ClientCore/DeleteClient?id=', id, 'SP');
}

{
    var clientLogId = new Array();
    clientLogId.push(client);
    clientLogId.push(logId);
    return Bjax('/api/ClientCore/UpdateClient', clientLogId, 'LP');
}

{
    return Bjax('/api/ClientCore/SelectAllClients', '', 'G');
}

{
    return Bjax('/api/ClientCore/SelectClientById?id=', id, 'SP');
}

{
    return Bjax('/api/ClientCore/SelectClientByFirstName?firstName=', firstName, 'SP');
}

{
    var args = new Array();
    args.push(firstName);
    args.push(lastName);
    return Bjax('/api/ClientCore/SelectClientByFirstNameAndLastName', args, 'LP');
}

{
    return Bjax('/api/ClientCore/SelectClientByLastName?lastName=', lastName, 'SP');
}

{
    return Bjax('/api/ClientCore/SelectClientByTellNo?tellNo=', tellNo, 'SP');
}

{
    return Bjax('/api/ClientCore/SelectClientByEmail?email=', email, 'SP');
}

{
    var args = new Array();
    args.push(username);
    args.push(password);
    return Bjax('/api/ClientCore/SelectClientByUsernameAndPassword', args, 'LP');
}

{
    return Bjax('/api/ClientCore/SelectClientByUsername?username=', username, 'SP');
}

{
    return Bjax('/api/ClientCore/SelectClientByPassword?password=', password, 'SP');
}
