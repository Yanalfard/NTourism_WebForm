using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblTicket
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ReciverId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string DateSended { get; set; }
        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblTicket(TblTicket ticket, HttpStatusCode statusEffect)
        {
            id = ticket.id;
            Name = ticket.Name;
            Email = ticket.Email;
            ReciverId = ticket.ReciverId;
            Title = ticket.Title;
            Text = ticket.Text;
            DateSended = ticket.DateSended;

            StatusEffect = statusEffect;
        }

        public DtoTblTicket()
        {
        }
    }
}