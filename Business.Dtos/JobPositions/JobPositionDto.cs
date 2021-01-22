namespace Business.Dtos.JobPositions
{
    public class JobPositionDto
    {
        public int JobGroupId { get; set; }
        public int JobLevelId { get; set; }
        public string JobLevelValue { get; set; }
        public string JobGroupCode { get; set; }
        public string JobGroupTitleEng { get; set; }
        public string JobGroupTitleFre { get; set; }
        public int JobGroupLevelId { get; set; }
        public string JobGroupLevelValue { get; set; }

        public int JobTitleId { get; set; }

        public string JobTitleFre { get; set; }
        public string JobTitleEng { get; set; }

        //optional
        public int JobCompetencyTypeId { get; set; }
        public int JobCompetencyId { get; set; }
        public int JobCompetencyRatingValue { get; set; }
        //public int JobPositionId { get; set; }
    }
}
