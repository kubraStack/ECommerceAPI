﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.JWT
{
    public class TokenOptions
    {
        public string SecurityKeys { get; set; }
        public int ExpirationTime { get; set; }
        public int RefreshTokenTTL { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
