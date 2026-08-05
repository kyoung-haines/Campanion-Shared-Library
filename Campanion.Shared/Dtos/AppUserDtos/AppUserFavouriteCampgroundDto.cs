using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.AppUserDtos
{
    public class AppUserFavouriteCampgroundDto
    {
        public string CampgroundId { get; set; } = string.Empty;
        public string AppUserId { get; set; } = string.Empty;
        public string CampgroundName { get; set; } = string.Empty;
        public string CampgroundImagePath { get; set; } = string.Empty;
    }
}
