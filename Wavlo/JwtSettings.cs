﻿namespace Wavlo
{
    public class JwtSettings
    {
            public string Key { get; set; }
            public string Issuer { get; set; }
            public string Audience { get; set; }
            public int DurationInDays { get; set; }


    }
}
