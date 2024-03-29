﻿using System.Collections.Generic;

namespace Business.Dtos.JobPositions
{
    public class JobPositionDto
    {
        public int JobGroupId { get; set; }
        public string JobLevelValue { get; set; }
        public int SubJobGroupId { get; set; }
        public string SubGroupCode { get; set; }
        public string JobGroupCode { get; set; }
        public string JobGroupLevelCode { get; set; }
        public string LevelCode { get; set; }
        public string JobGroupTitleEng { get; set; }
        public string JobGroupTitleFre { get; set; }
        public int JobGroupLevelId { get; set; }
        public int JobTitleId { get; set; }
        public string JobTitleFre { get; set; }
        public string JobTitleEng { get; set; }
        public string JobDescriptionFre { get; set; }
        public string JobDescriptionEng { get; set; }
        public List<int> Competencies {get;set;}
        public int Active { get; set; }
    }
}
