using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.AppUserDtos
{
    public class AppUserDto()
    {
        public string AppUserId { get; set; }   
        public string AppUserEmail { get; set; } = string.Empty;
        public string AppUserPhone { get; set; } = string.Empty;
        public string AppUserType { get; set; } = string.Empty;
        public string AppUserFirstName { get; set; } = string.Empty;
        public string AppUserLastName { get; set; } = string.Empty;
        public string AppUserStreetAddress { get; set; } = string.Empty;
        public string AppUserCity { get; set; } = string.Empty;
        public string AppUserProvince { get; set; } = string.Empty;
        public string AppUserCountry { get; set; } = string.Empty;
        public string AppUserPostalCode { get; set; } = string.Empty;
        public List<AppUserFavouriteCampgroundDto> AppUserFavouriteCampgrounds { get; set; } = new();
        public List<AppUserTripDto> AppUserTrips { get; set; } = new();
    }
}
