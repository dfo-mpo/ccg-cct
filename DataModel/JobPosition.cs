using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class JobPosition
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string PositionNameEng { get; set; }

        [StringLength(150)]
        public string PositionNameFre { get; set; }

        // entity will hold all of the JobPositionCompetency entities that are related to that JobPosition entity.
        public virtual ICollection<JobPositionCompetency> JobPositionCompetency { get; set; }

        // entity will hold all of the JobRolesPositionCompetency entities that are related to that JobPosition entity.
        public virtual ICollection<JobRolesPositionCompetency> JobRolesPositionCompetency { get; set; }
        
    }
}
