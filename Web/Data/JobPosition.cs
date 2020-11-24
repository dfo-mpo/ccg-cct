using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Data
{
    public class JobPosition
    {
        public int JobGroupId { get; set; }
        public string JobGroupCode { get; set; }
        public string JobGroupTitleEng { get; set; }
        public string JobGroupTitleFre { get; set; }
        public int JobGroupLevelId { get; set; }
        public string JobGroupLevelValue { get; set; }

        public int JobTitleId { get; set; }

        public string JobTitleFre { get; set; }
        public string JobTitleEng { get; set; }
    }
}
