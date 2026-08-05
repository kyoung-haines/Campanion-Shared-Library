using Campanion.Shared.Dtos.AppUserDtos;
using Campanion.Shared.Dtos.TripDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.ProfileDtos
{
    public class ProfileResponseDto
    {
        public string ProfileId { get; set; } = string.Empty;
        public string ProfileUsername { get; set; } = string.Empty;
        public string ProfileUserProvince { get; set; } = string.Empty;
        public string ProfileUserCountry { get; set; } = string.Empty;
        public string ProfileImagePath { get; set; } = string.Empty;
        public string ProfileCreatedAt { get; set; } = string.Empty;
        public string AppUserId { get; set; } = string.Empty;
        public AppUserFavouriteCampgroundsDto ProfileUserFavouriteCampgrounds { get; set; } = new();
        public UpcomingTripsDto ProfileUserUpcomingTrips { get; set; } = new(new UpcomingTripDto());
    }
}
