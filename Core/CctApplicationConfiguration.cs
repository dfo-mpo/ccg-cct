using CCG.AspNetCore.Common.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class CctApplicationConfiguration : ApplicationConfiguration
    {
        public bool MigrationsOnStartup { get; set; }
    }
}
