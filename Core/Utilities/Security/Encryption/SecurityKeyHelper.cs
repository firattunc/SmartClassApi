﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public static class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securitKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securitKey));
        }
    }
}
