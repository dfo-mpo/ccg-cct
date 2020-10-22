using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class JobRoles
    {

        public int JobGroupId { get; set; }

        public JobGroup JobGroup { get; set; }

        public int JobGroupLevelId { get; set; }

        public JobGroupLevel JobGroupLevel { get; set; }

    }
}
