using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.CampgroundDtos
{
    public class CampgroundDto
    {
        public string CampgroundIdDto { get; set; } = string.Empty;
        public string CampgroundNameDto { get; set; } = string.Empty;
        public string CampgroundImagePathDto { get; set; } = "images/campgrounds/placeholder-campground.png";
        public string CampgroundStreetNameDto { get; set; } = string.Empty;
        public string CampgroundCityDto { get; set; } = string.Empty;
        public string CampgroundProvinceDto { get; set; } = string.Empty;
        public string CampgroundCountryDto { get; set; } = string.Empty;
        public string CampgroundPostalCodeDto { get; set; } = string.Empty;
        public string CampgroundPhoneDto { get; set; } = string.Empty;
        public string CampgroundEmailDto { get; set; } = "N/A";
        public string CampgroundTypeDto { get; set; } = string.Empty;
        public string CampgroundIsOpenYearRoundDto { get; set; } = string.Empty;
        public string CampgroundOpenDateDto { get; set; } = string.Empty;
        public string CampgroundCloseDateDto { get; set; } = string.Empty;
        public string CampgroundHasFacilitiesDto { get; set; } = string.Empty;
        public List<string> CampgroundFacilitiesDto { get; set; } = new();
        public string CampgroundHasActivitiesDto { get; set; } = string.Empty;
        public List<string> CampgroundActivitiesDto { get; set; } = new();
        public string CampgroundUrlDto { get; set; } = string.Empty;
        public List<string> FavouritedByDto { get; set; } = new();
    }
}
