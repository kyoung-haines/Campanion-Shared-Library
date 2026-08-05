using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Campanion.Shared.Dtos.TripDtos
{
    public class CreateTripDto
    {
        [Required]
        public string TripName { get; set; } = string.Empty;
        [Required]
        public DateOnly TripStartDate { get; set; } = new();
        [Required]
        public DateOnly TripEndDate { get; set; } = new();
        public DateTime TripCreatedAt { get; set; } = new();


        // this will need to refactored
        // this should be a list of users (friends) that have been added
        // it won't be strings I don't think
        public List<TripAttendeeDto> TripAttendees { get; set; } = new();
    }
}
