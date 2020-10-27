using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Queries.Dtos
{
    public class JobPositionDto
    {
        public int ClassificationId { get; set; }
        public string Classification { get; set; }

        public int ClassificationLevelId { get; set; }
        public string ClassificationLevel { get; set; }

        public int JobPositionId { get; set; }
        public string JobPositionTitleFre { get; set; }
        public string JobPositionTitleEng { get; set; }

    }
}
