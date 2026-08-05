using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.TripDtos
{
    public class TripDto
    {
        public string TripId { get; set; } = string.Empty;
        public string? TripName { get; set; } = string.Empty;
        public string TripStatus { get; set; } = string.Empty;
        public string TripStartDate { get; set; } = string.Empty;
        public string TripEndDate { get; set; } = string.Empty;
        public string TripCreationDate { get; set; } = string.Empty;
        public List<TripAttendeeDto> TripAttendees { get; set; } = new();
    }
}