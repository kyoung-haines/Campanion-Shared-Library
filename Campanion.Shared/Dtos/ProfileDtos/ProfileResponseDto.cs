using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.ProfileDtos
{
    public class ProfileResponseDto
    {
        public string ProfileId { get; set; }
        public string ProfileUsername { get; set; }
        public string ProfileUserProvince { get; set; }
        public string ProfileUserCountry { get; set; }
        public string ProfileImagePath { get; set; }
        public string ProfileCreatedAt { get; set; }
        public string AppUserId { get; set; }
    }
}
