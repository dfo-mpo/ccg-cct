using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class JobPosition
    {
        public int JobPositionId { get; set; }

        public string JobPositionTitleEng { get; set; }

        public string JobPositionTitleFra { get; set; }

        // entity will hold all of the JobPositionCompetency entities that are related to that JobPosition entity.
        public virtual ICollection<JobPositionCompetency> JobPositionCompetency { get; set; }

        // entity will hold all of the JobRolesPositionCompetency entities that are related to that JobPosition entity.
        public virtual ICollection<JobRolesPositionCompetency> JobRolesPositionCompetency { get; set; }

    }
}
