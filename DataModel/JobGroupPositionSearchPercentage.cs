using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class JobGroupPositionSearchPercentage 
    {
        public int JobGroupPositionId { get; set; }
        public JobGroupPosition JobGroupPosition { get; set; }
        public int SearchPercentageId { get; set; }
        public SearchPercentage SearchPercentage { get; set; } 
        public int JobGroupId { get; set; }
        public JobGroup JobGroup { get; set; }
        public int SubJobGroupId { get; set; }
        public SubJobGroup SubJobGroup { get; set; }
        public int JobGroupLevelId { get; set; }
        public JobGroupLevel JobGroupLevel { get; set; }

        public int JobPositionId { get; set; }
        public JobPosition JobPosition { get; set; }

    }

}
