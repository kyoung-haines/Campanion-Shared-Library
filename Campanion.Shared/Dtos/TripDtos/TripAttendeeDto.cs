using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.TripDtos
{
    public class TripAttendeeDto
    {
        public string TripAttendeeName { get; set; } = string.Empty;
        public string TripAttendeeProfileImagePath { get; set; } = string.Empty;
        public string TripAttendeeEmail { get; set; } = string.Empty;
    }
}
