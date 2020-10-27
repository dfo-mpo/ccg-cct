using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Queries.Dtos
{
    class JobRoleDto
    {
        public int ClassificationId { get; set; }
        public string Classification { get; set; }

        public int ClassificationLevelId { get; set; }
        public string ClassificationLevel { get; set; }
    }
}
