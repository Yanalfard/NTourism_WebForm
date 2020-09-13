using System.ComponentModel.DataAnnotations;

namespace NTourism.Models.Regular
{
    public class TblClient
    {
        public int id { get; set; }
        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Display(Name = "TellNo")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MaxLength(15)]
        public string TellNo { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MaxLength(20)]
        public string Username { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MaxLength(50)]
        public string Password { get; set; }
        public int Status { get; set; }
        public TblClient(int id)
        {
            this.id = id;
        }
        public TblClient(string firstName, string lastName, string tellNo, string email, string username, string password, int status)
        {
            FirstName = firstName;
            LastName = lastName;
            TellNo = tellNo;
            Email = email;
            Username = username;
            Password = password;
            Status = status;
        }

        public TblClient(int id, string firstName, string lastName, string tellNo, string email, string username, string password, int status)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            TellNo = tellNo;
            Email = email;
            Username = username;
            Password = password;
            Status = status;
        }

        public TblClient()
        {
        }
    }
}