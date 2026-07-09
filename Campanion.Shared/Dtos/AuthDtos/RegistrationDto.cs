using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.AuthDtos
{
    public class RegistrationDto
    {
        public string AppUserId { get; set; } = string.Empty;
        public string AppUserType { get; set; } = string.Empty;
        public string AppUserUsername { get; set; } = string.Empty;
        public string AppUserPassword { get; set; } = string.Empty;
        public string AppUserEmail { get; set; } = string.Empty;
        public string AppUserPhone { get; set; } = string.Empty;
        public required string AppUserFirstName { get; set; } = string.Empty;
        public required string AppUserLastName { get; set; } = string.Empty;
        public string AppUserStreetAddress { get; set; } = string.Empty;
        public string AppUserCity { get; set; } = string.Empty;
        public required string AppUserProvince { get; set; } = string.Empty;
        public required string AppUserCountry { get; set; } = string.Empty;
        public string AppUserPostalCode { get; set; } = string.Empty;
    }
}
