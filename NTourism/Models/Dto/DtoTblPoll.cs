using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblPoll
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Vote { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblPoll(TblPoll poll, HttpStatusCode statusEffect)
        {
            id = poll.id;
            Name = poll.Name;
            Vote = poll.Vote;

            StatusEffect = statusEffect;
        }

        public DtoTblPoll()
        {
        }
    }
}