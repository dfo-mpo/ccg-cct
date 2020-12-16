namespace Business.Dtos.JobCompetencies
{
    public class JobCompetencyRatingDto
    {
        public int JobPositionId { get; set; }
        public int TypeId { get; set; }
        public string TypeNameEng { get; set; }
        public string TypeNameFre { get; set; }

        public int CompetencyId { get; set; }
        public string CompetencyNameEng { get; set; }

        public string CompetencyNameFre { get; set; }

        public string CompetencyDescEng { get; set; }

        public string CompetencyDescFre { get; set; }

        public int RatingValue { get; set; } 

        public string RatingNameEng { get; set; } 

        public string RatingNameFre { get; set; }

        public string RatingDescEng { get; set; }

        public string RatingDescFre { get; set; }
        public string CompetencyLevelReqDescEng { get; set; }
        public string CompetencyLevelReqDescFre { get; set; }
    }
}
