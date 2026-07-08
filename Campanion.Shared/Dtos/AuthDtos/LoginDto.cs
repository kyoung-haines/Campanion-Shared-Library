using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.AuthDtos
{
    public class LoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
