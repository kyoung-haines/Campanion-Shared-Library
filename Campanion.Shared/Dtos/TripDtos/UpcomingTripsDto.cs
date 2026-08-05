using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.TripDtos
{
    public class UpcomingTripsDto
    {
        public List<UpcomingTripDto>? UpcomingTripDtos { get; set; } = new();

        public UpcomingTripsDto(UpcomingTripDto upcomingTripDto)
        {
            this.UpcomingTripDtos!.Add(upcomingTripDto); 
        }
    }
}
