namespace Business.Dtos.Shared
{
    public class SharedJobCertificateDto
    {
        public int Id { get; set; }

        public string NameEng { get; set; } 

        public string NameFre { get; set; }

        public string DescEng { get; set; }

        public string DescFre { get; set; }

        public int Active { get; set; } 
        public string CurrentPositionHas { get; set; }
        public string ObjectivePositionHas { get; set; }
    
    }
}
