using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class Certificate : CompetencyType
    {
        [StringLength(150)]
        public string DescriptionEng { get; set; }

        [StringLength(150)]
        public string DescriptionFre { get; set; }

        [StringLength(150)]
        public string RequireIndicatorEng { get; set; }

        [StringLength(150)]
        public string RequireIndicatorFre { get; set; }
    }
}
