using System.ComponentModel.DataAnnotations;

namespace NTourism.Models.Regular
{
    public class TblRoomHome
    {
        public int id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please Select{0}")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Display(Name = "MainImage")]
        [Required(ErrorMessage = "Please Select{0}")]
        public string MainImage { get; set; }
        public int ClientId { get; set; }
        public int CityId { get; set; }
        [Display(Name = "PriceNormal")]
        [Required(ErrorMessage = "Please Select{0}")]
        public long PriceNormal { get; set; }
        [Display(Name = "PriceWeekend")]
        [Required(ErrorMessage = "Please Select{0}")]
        public long PriceWeekend { get; set; }
        [Display(Name = "DaysOccupaid")]
        [Required(ErrorMessage = "Please Select{0}")]
        public int DaysOccupaid { get; set; }
        [Display(Name = "OccupaidFrom")]
        [MaxLength(50)]
        public string OccupaidFrom { get; set; }
        [Display(Name = "OccupaidTo")]
        [MaxLength(50)]
        public string OccupaidTo { get; set; }
        public bool IsReserved { get; set; }
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(50)]
        public string Description { get; set; }
        public bool IsSelected { get; set; }

        public TblRoomHome(int id)
        {
            this.id = id;
        }

        public TblRoomHome(int id, string name, string mainImage, int clientId, int cityId, long priceNormal, long priceWeekend, int daysOccupaid, string occupaidFrom, string occupaidTo, bool isReserved, string description, bool isSelected)
        {
            this.id = id;
            Name = name;
            MainImage = mainImage;
            ClientId = clientId;
            CityId = cityId;
            PriceNormal = priceNormal;
            PriceWeekend = priceWeekend;
            DaysOccupaid = daysOccupaid;
            OccupaidFrom = occupaidFrom;
            OccupaidTo = occupaidTo;
            IsReserved = isReserved;
            Description = description;
            IsSelected = isSelected;
        }

        public TblRoomHome(string name, string mainImage, int clientId, int cityId, long priceNormal, long priceWeekend, int daysOccupaid, string occupaidFrom, string occupaidTo, bool isReserved, string description, bool isSelected)
        {
            Name = name;
            MainImage = mainImage;
            ClientId = clientId;
            CityId = cityId;
            PriceNormal = priceNormal;
            PriceWeekend = priceWeekend;
            DaysOccupaid = daysOccupaid;
            OccupaidFrom = occupaidFrom;
            OccupaidTo = occupaidTo;
            IsReserved = isReserved;
            Description = description;
            IsSelected = isSelected;
        }

        public TblRoomHome()
        {

        }
    }
}