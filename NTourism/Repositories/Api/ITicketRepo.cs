using System.Collections.Generic;
using NTourism.Models.Regular;

namespace NTourism.Repositories.Api
{
    public interface ITicketRepo
    {
        TblTicket AddTicket(TblTicket ticket);
        bool DeleteTicket(int id);
        bool UpdateTicket(TblTicket ticket, int logId);
        List<TblTicket> SelectAllTickets();
        TblTicket SelectTicketById(int id);
        List<TblTicket> SelectTicketBySenderId(int senderId);
        List<TblTicket> SelectTicketByReciverId(int reciverId);
        TblTicket SelectTicketByTitle(string title);

    }
}