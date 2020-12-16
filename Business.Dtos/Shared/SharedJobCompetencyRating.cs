namespace Business.Dtos.Shared
{
    public class SharedJobCompetencyRating
    {
        public int TypeId { get; set; }
        public string TypeNameEng { get; set; }
        public string TypeNameFre { get; set; }
        public int CompetencyId { get; set; }
        public string CompetencyNameEng { get; set; }
        public string CompetencyNameFre { get; set; }
        public string CompetencyDescEng { get; set; }
        public string CompetencyDescFre { get; set; }
        public string RatingValueCur { get; set; } 
        public string RatingValueObj { get; set; }
        public string RatingNameCurEng { get; set; }
        public string RatingNameCurFre { get; set; }
        public string RatingNameObjEng { get; set; }
        public string RatingNameObjFre { get; set; }
        public string RatingDescCurEng { get; set; }
        public string RatingDescCurFre { get; set; }
        public string RatingDescObjEng { get; set; }
        public string RatingDescObjFre { get; set; }
        public string CompetencyLevelReqDescCurEng { get; set; }
        public string CompetencyLevelReqDescCurFre { get; set; }
        public string CompetencyLevelReqDescObjEng { get; set; }
        public string CompetencyLevelReqDescObjFre { get; set; }
    }
}
