//---> int id
//---> string Name
//---> string Email
//---> int ReciverId
//---> string Title
//---> string Text
//---> string DateSended
function AddTicket(ticket)
{
    return Bjax('/api/TicketCore/AddTicket', ticket, 'LP');
}
function DeleteTicket(id)
{
    return Bjax('/api/TicketCore/DeleteTicket?id=', id, 'SP');
}
function UpdateTicket(ticket, logId)
{
    var ticketLogId = new Array();
    ticketLogId.push(ticket);
    ticketLogId.push(logId);
    return Bjax('/api/TicketCore/UpdateTicket', ticketLogId, 'LP');
}
function SelectAllTickets()
{
    return Bjax('/api/TicketCore/SelectAllTickets', '', 'G');
}
function SelectTicketById(id)
{
    return Bjax('/api/TicketCore/SelectTicketById?id=', id, 'SP');
}
function SelectTicketByName(name)
{
    return Bjax('/api/TicketCore/SelectTicketByName?name=', name, 'SP');
}
function SelectTicketByEmail(email)
{
    return Bjax('/api/TicketCore/SelectTicketByEmail?email=', email, 'SP');
}
function SelectTicketByReciverId(reciverId)
{
    return Bjax('/api/TicketCore/SelectTicketByReciverId?reciverId=', reciverId, 'SP');
}
function SelectTicketByTitle(title)
{
    return Bjax('/api/TicketCore/SelectTicketByTitle?title=', title, 'SP');
}
