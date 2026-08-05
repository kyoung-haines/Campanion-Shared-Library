using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.AuthDtos
{
    public class AuthResponseDto
    {
        public string Token { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public DateTime TokenExpiry { get; set; } = new();
    }
}
