using System.Collections.Generic;
using System.Linq;
using NTourism.Models.Regular;
using NTourism.Repositories.Api;
using NTourism.Utilities;

namespace NTourism.Repositories.Impl
{
    public class TicketRepo : ITicketRepo
    {
        public TblTicket AddTicket(TblTicket ticket)
        {
            return (TblTicket)new MainProvider().Add(ticket);
        }
        public bool DeleteTicket(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblTicket, id);
        }
        public bool UpdateTicket(TblTicket ticket, int logId)
        {
            return new MainProvider().Update(ticket, logId);
        }
        public List<TblTicket> SelectAllTickets()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblTicket).Cast<TblTicket>().ToList();
        }
        public TblTicket SelectTicketById(int id)
        {
            return (TblTicket)new MainProvider().SelectById(MainProvider.Tables.TblTicket, id);
        }
        public List<TblTicket> SelectTicketBySenderId(int senderId)
        {
            return new MainProvider().SelectTicketBySenderId(senderId);
        }
        public List<TblTicket> SelectTicketByReciverId(int reciverId)
        {
            return new MainProvider().SelectTicketByReciverId(reciverId);
        }
        public TblTicket SelectTicketByTitle(string title)
        {
            return new MainProvider().SelectTicketByTitle(title);
        }

    }
}