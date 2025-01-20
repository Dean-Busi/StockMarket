using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    public interface ITokenGenerator
    {
        string CreateAccessToken(User user);

        string CreateRefreshToken();
    }
}