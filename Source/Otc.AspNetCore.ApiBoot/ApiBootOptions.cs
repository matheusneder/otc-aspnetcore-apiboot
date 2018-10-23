﻿namespace Otc.AspNetCore.ApiBoot
{
    public class ApiBootOptions
    {
        public bool EnableSwagger { get; set; } = true;
        public bool EnableLogging { get; set; } = true;
        public LoggingType LoggingType { get; set; } = LoggingType.ApiBootStdout;
    }
}