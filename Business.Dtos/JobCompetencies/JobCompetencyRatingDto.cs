namespace Business.Dtos.JobCompetencies
{
    public class JobCompetencyRatingDto
    {
        public int JobPositionId { get; set; }
        public int TypeId { get; set; }
        public string TypeNameEng { get; set; } // ex. Behavioral, knowledge, technical
        public string TypeNameFre { get; set; }

        public int CompetencyId { get; set; }
        public string CompetencyNameEng { get; set; }

        public string CompetencyNameFre { get; set; }

        public string CompetencyDescEng { get; set; }

        public string CompetencyDescFre { get; set; }
        //public int RatingId { get; set; }

        public int RatingValue { get; set; } // ex: 1, 2

        public string RatingNameEng { get; set; } // ex: Novice, Intermediate

        public string RatingNameFre { get; set; }

        public string RatingDescEng { get; set; }

        public string RatingDescFre { get; set; }
    }
}
