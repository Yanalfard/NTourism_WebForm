using System.ComponentModel.DataAnnotations;

namespace NTourism.Models.Regular
{
    public class TblNews
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Select Enter {0}")]
        [Display(Name = "Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Select Enter {0}")]
        [Display(Name = "Title")]
        [MaxLength(50)]
        public string Title { get; set; }
        public int OrderId { get; set; }

        public int TextId { get; set; }

        public int ImageId { get; set; }

        public bool IsText { get; set; }

        public bool IsSelected { get; set; }

        public string MainImage { get; set; }

        public bool IsValid { get; set; }

        public bool IsPinned { get; set; }


        public TblNews(int id)
        {
            this.id = id;
        }

        public TblNews(string name, string title, int orderId, int textId, int imageId, bool isText, bool isSelected, string mainImage, bool isValid, bool isPinned)
        {
            Name = name;
            Title = title;
            OrderId = orderId;
            TextId = textId;
            ImageId = imageId;
            IsText = isText;
            IsSelected = isSelected;
            MainImage = mainImage;
            IsValid = isValid;
            IsPinned = isPinned;
        }

        public TblNews(int id, string name, string title, int orderId, int textId, int imageId, bool isText, bool isSelected, string mainImage, bool isValid, bool isPinned)
        {
            this.id = id;
            Name = name;
            Title = title;
            OrderId = orderId;
            TextId = textId;
            ImageId = imageId;
            IsText = isText;
            IsSelected = isSelected;
            MainImage = mainImage;
            IsValid = isValid;
            IsPinned = isPinned;
        }

        public TblNews()
        {
        }
    }
}