using System.ComponentModel.DataAnnotations;

namespace NTourism.Models.Regular
{
    public class TblTicket
    {
        public int id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(150)]
        public string Email { get; set; }
        public int ReciverId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string DateSended { get; set; }

        public TblTicket(int id)
        {
            this.id = id;
        }

        public TblTicket(int id, string name, string email, int reciverId, string title, string text, string dateSended)
        {
            this.id = id;
            Name = name;
            Email = email;
            ReciverId = reciverId;
            Title = title;
            Text = text;
            DateSended = dateSended;
        }
        public TblTicket(string name, string email, int reciverId, string title, string text, string dateSended)
        {
            Name = name;
            Email = email;
            ReciverId = reciverId;
            Title = title;
            Text = text;
            DateSended = dateSended;
        }

        public TblTicket()
        {

        }
    }
}