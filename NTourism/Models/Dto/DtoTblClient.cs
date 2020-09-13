using System.Net;
using NTourism.Models.Regular;

namespace NTourism.Models.Dto
{
    public class DtoTblClient
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TellNo { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Status { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public DtoTblClient(TblClient client, HttpStatusCode statusEffect)
        {
            id = client.id;
            FirstName = client.FirstName;
            LastName = client.LastName;
            TellNo = client.TellNo;
            Email = client.Email;
            Username = client.Username;
            Password = client.Password;
            Status = client.Status;
            StatusEffect = statusEffect;
        }

        public DtoTblClient()
        {
        }
    }
}