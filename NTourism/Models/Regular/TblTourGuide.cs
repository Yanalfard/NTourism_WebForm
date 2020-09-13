using System.ComponentModel.DataAnnotations;

namespace NTourism.Models.Regular
{
    public class TblTourGuide
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
        [DataType(DataType.EmailAddress)]
        [MaxLength(80)]
        public string Email { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        public string MainImage { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        public string Description { get; set; }
        public int CityId { get; set; }
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MinLength(5)]
        [MaxLength(50)]
        public string Username { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        [MinLength(7)]
        [MaxLength(50)]
        public string Password { get; set; }

        public int Rate { get; set; }

        public int Discount { get; set; }

        public int Price { get; set; }
        
        public TblTourGuide(int id)
        {
            this.id = id;
        }

        public TblTourGuide(string firstName, string lastName, string tellNo, string email, string mainImage, string description, int cityId, string username, string password, int rate, int discount,int price)
        {
            FirstName = firstName;
            LastName = lastName;
            TellNo = tellNo;
            Email = email;
            MainImage = mainImage;
            Description = description;
            CityId = cityId;
            Username = username;
            Password = password;
            Rate = rate;
            Discount = discount;
            Price = price;
        }

        public TblTourGuide(int id, string firstName, string lastName, string tellNo, string email, string mainImage, string description, int cityId, string username, string password, int rate, int discount, int price)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            TellNo = tellNo;
            Email = email;
            MainImage = mainImage;
            Description = description;
            CityId = cityId;
            Username = username;
            Password = password;
            Rate = rate;
            Discount = discount;
            Price = price;
        }

        public TblTourGuide()
        {
        }
    }
}