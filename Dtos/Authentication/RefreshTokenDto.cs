using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos
{
    public class RefreshTokenDto
    {
        public string? Username { get; set; }

        public string? RefreshToken { get; set; }
    }
}

