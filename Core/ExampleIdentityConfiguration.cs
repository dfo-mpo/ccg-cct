using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Common.Configuration;

namespace Core
{
    public class ExampleIdentityConfiguration : CcgAccountClientConfiguration
    {
        public string ClientId { get; set; }
        public string ClientAudience { get; set; }
        public string ClientScope { get; set; }
        public string GisAudience { get; set; }

        public List<string> ValidAudiences => new List<string>() {ClientAudience, GisAudience};
    }
}
