﻿namespace Business.Dtos.JobCompetencies
{
    public class JobCertificateDto
    {
            public int Id { get; set; }
            public int CertificateDescId { get;set; }
            public string NameEng { get; set; }

            public string NameFre { get; set; }

            public string DescEng { get; set; }

            public string DescFre { get; set; }
        public int Active { get; set; }
    }
}

