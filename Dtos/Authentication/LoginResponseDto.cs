using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos
{
    public class LoginResponseDto
    {
        public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? AccessToken { get; set; }
    }
}


