using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.TripDtos
{
    public class TripDto
    {
        public string TripId { get; set; }
        public string? TripName { get; set; }
        public string TripStatus { get; set; }
        public string TripStartDate { get; set; }
        public string TripEndDate { get; set; }
        public string TripCreationDate { get; set; }
        public List<object> TripAttendees { get; set; }
    }
}