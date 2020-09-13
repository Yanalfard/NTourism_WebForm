//---> int id
//---> string FirstName
//---> string LastName
//---> string TellNo
//---> string Email
//---> string Username
//---> string Password
//---> int Status
function AddClient(client)
{
    return Bjax('/api/ClientCore/AddClient', client, 'LP');
}
function DeleteClient(id)
{
    return Bjax('/api/ClientCore/DeleteClient?id=', id, 'SP');
}
function UpdateClient(client, logId)
{
    var clientLogId = new Array();
    clientLogId.push(client);
    clientLogId.push(logId);
    return Bjax('/api/ClientCore/UpdateClient', clientLogId, 'LP');
}
function SelectAllClients()
{
    return Bjax('/api/ClientCore/SelectAllClients', '', 'G');
}
function SelectClientById(id)
{
    return Bjax('/api/ClientCore/SelectClientById?id=', id, 'SP');
}
function SelectClientByFirstName(firstName)
{
    return Bjax('/api/ClientCore/SelectClientByFirstName?firstName=', firstName, 'SP');
}
function SelectClientByFirstNameAndLastName(firstName, lastName)
{
    var args = new Array();
    args.push(firstName);
    args.push(lastName);
    return Bjax('/api/ClientCore/SelectClientByFirstNameAndLastName', args, 'LP');
}
function SelectClientByLastName(lastName)
{
    return Bjax('/api/ClientCore/SelectClientByLastName?lastName=', lastName, 'SP');
}
function SelectClientByTellNo(tellNo)
{
    return Bjax('/api/ClientCore/SelectClientByTellNo?tellNo=', tellNo, 'SP');
}
function SelectClientByEmail(email)
{
    return Bjax('/api/ClientCore/SelectClientByEmail?email=', email, 'SP');
}
function SelectClientByUsernameAndPassword(username, password)
{
    var args = new Array();
    args.push(username);
    args.push(password);
    return Bjax('/api/ClientCore/SelectClientByUsernameAndPassword', args, 'LP');
}
function SelectClientByUsername(username)
{
    return Bjax('/api/ClientCore/SelectClientByUsername?username=', username, 'SP');
}
function SelectClientByPassword(password)
{
    return Bjax('/api/ClientCore/SelectClientByPassword?password=', password, 'SP');
}
