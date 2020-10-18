using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class Certificate : CompetencyType
    {
        public string CertificateDescriptionEng { get; set; }

        public string CertificateDescriptionFra { get; set; }

        public string RequireIndicatorEng { get; set; }

        public string RequireIndicatorFra { get; set; }
    }
}
