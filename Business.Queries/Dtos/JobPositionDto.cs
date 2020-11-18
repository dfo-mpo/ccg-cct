using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Queries.Dtos
{
    public class JobPositionDto
    {
        public int JobGroupId { get; set; }
        public int JobLevelId { get; set; }
        public string JobLevelValue { get; set; }
        public string JobGroupCodeEng { get; set; }
        public string JobGroupCodeFre { get; set; }
        public int JobGroupLevelId { get; set; }
        public string JobGroupLevelValue { get; set; }

        public int JobTitleId { get; set; }

        public string JobTitleFre { get; set; }
        public string JobTitleEng { get; set; }
    }
}