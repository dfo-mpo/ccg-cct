using System.Collections.Generic;

namespace Business.Dtos.JobPositions
{
    public class JobPositionDto
    {
        public int JobGroupId { get; set; }
        public int JobLevelId { get; set; }
        public int JobLevelValue { get; set; }
        public string JobGroupCode { get; set; }
        public string JobGroupTitleEng { get; set; }
        public string JobGroupTitleFre { get; set; }
        public int JobGroupLevelId { get; set; }
        public int JobGroupLevelValue { get; set; }
        public int JobTitleId { get; set; }
        public string JobTitleFre { get; set; }
        public string JobTitleEng { get; set; }
        public List<int> Competencies {get;set;}
    }
}
