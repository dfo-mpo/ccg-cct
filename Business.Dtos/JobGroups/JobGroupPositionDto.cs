namespace Business.Dtos.JobGroups
{
    public class JobGroupPositionDto
    {
        public int JobId { get; set; }
        public int SubJobGroupId { get;set; }
        public int JobGroupId { get; set; }
        public string SubGroupCode { get; set; }
        public string LevelCode { get; set; }
        public int LevelId { get; set; }
        public string LevelValue { get; set; }
        public int Active { get; set; }

    }
}
