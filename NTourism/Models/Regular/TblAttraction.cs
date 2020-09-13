using System.ComponentModel.DataAnnotations;

namespace NTourism.Models.Regular
{
    public class TblAttraction
    {
        //Status 0 is Attraction 1 is Event 2 is TripStory
        public int id { get; set; }
        [MaxLength(150)]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        public string Name { get; set; }
        [MaxLength(150)]
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Please Enter {0} ")]
        public string Title { get; set; }

        public int TextId { get; set; }

        public int ImageId { get; set; }

        public bool IsText { get; set; }

        public int CityId { get; set; }
      
        public int Score { get; set; }

        public int OrderId { get; set; }

        public int Status { get; set; }

        public bool IsSelected { get; set; }

        public TblAttraction(int id)
        {
            this.id = id;
        }

        public TblAttraction(string name, string title, int textId, int imageId, bool isText, int cityId, int score, int orderId, int status, bool isSelected)
        {
            Name = name;
            Title = title;
            TextId = textId;
            ImageId = imageId;
            IsText = isText;
            CityId = cityId;
            Score = score;
            OrderId = orderId;
            Status = status;
            IsSelected = isSelected;
        }

        public TblAttraction(int id, string name, string title, int textId, int imageId, bool isText, int cityId, int score, int orderId, int status, bool isSelected)
        {
            this.id = id;
            Name = name;
            Title = title;
            TextId = textId;
            ImageId = imageId;
            IsText = isText;
            CityId = cityId;
            Score = score;
            OrderId = orderId;
            Status = status;
            IsSelected = isSelected;
        }

        public TblAttraction()
        {
        }
    }
}