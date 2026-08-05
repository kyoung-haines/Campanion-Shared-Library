using Campanion.Shared.Dtos.ProfileDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.AuthDtos
{
    public class RegisterResponseDto
    {
        public string Token { get; set; } = string.Empty;
        public ProfileResponseDto Profile { get; set; } = string.Empty;
    }
}
