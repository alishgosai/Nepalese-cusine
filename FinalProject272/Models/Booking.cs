using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject272.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        [Required]
        public string Name { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Required]

        public SpecialRequirementType SpecialRequirements { get; set; }
        public bool IsLunch { get; set; }
        public bool IsDinner { get; set; }

        [DataType(DataType.Date)]
        public DateTime SelectedDate { get; set; }

        [DataType(DataType.Time)]
        public DateTime SelectedTime { get; set; }
        [Required]
        public int PartySize { get; set; }

    }

    public enum SpecialRequirementType
    {
        None,
        Birthday,
        Anniversary,
        GraduationParty,
        WeddingParty
    }
}
