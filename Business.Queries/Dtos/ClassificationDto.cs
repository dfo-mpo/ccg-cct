using System;

namespace Business.Queries.Dtos
{
    public class ClassificationDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }
    }
}