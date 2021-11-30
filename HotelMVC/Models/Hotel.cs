using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMVC.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [Display(Name = "Hotel")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string HotelName { get; set; }

        [Required]
        public HotelSize Size { get; set; }

        [Display(Name = "Free Rooms")]
        [Range(0,1000)]
        public int NumberOfFreeRooms { get; set; }

        [Display(Name = "Room Price")]
        [DataType(DataType.Currency)]
        [Range(50, 1000)]
        public int RoomPrice { get; set; }

        [Display(Name = "Founded In")]
        [RegularExpression(@"^(18|19|20)\d{2}$", ErrorMessage = "Please enter a year from 1800 to 2099")]
        [Required]
        public string  FoundedIn{ get; set; }
        [Display(Name = "VIPs")]
        [Required]
        public bool VIPs { get; set; }

        public string IsVIP
        {
            get
            {
                return VIPs ? "Yes" : "No";
            }
        }

        public enum HotelSize
        {
            Enormous,
            Big,
            Medium,
            Small
        }
    }
}
