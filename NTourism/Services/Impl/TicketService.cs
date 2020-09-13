using System.Collections.Generic;
using NTourism.Models.Regular;
using NTourism.Repositories.Impl;
using NTourism.Services.Api;

namespace NTourism.Services.Impl
{
    public class TicketService : ITicketService
    {
        public TblTicket AddTicket(TblTicket ticket)
        {
            return (TblTicket)new TicketRepo().AddTicket(ticket);
        }
        public bool DeleteTicket(int id)
        {
            return new TicketRepo().DeleteTicket(id);
        }
        public bool UpdateTicket(TblTicket ticket, int logId)
        {
            return new TicketRepo().UpdateTicket(ticket, logId);
        }
        public List<TblTicket> SelectAllTickets()
        {
            return new TicketRepo().SelectAllTickets();
        }
        public TblTicket SelectTicketById(int id)
        {
            return (TblTicket)new TicketRepo().SelectTicketById(id);
        }
        public List<TblTicket> SelectTicketBySenderId(int senderId)
        {
            return new TicketRepo().SelectTicketBySenderId(senderId);
        }
        public List<TblTicket> SelectTicketByReciverId(int reciverId)
        {
            return new TicketRepo().SelectTicketByReciverId(reciverId);
        }
        public TblTicket SelectTicketByTitle(string title)
        {
            return new TicketRepo().SelectTicketByTitle(title);
        }

    }
}