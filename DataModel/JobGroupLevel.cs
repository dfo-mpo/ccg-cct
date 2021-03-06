﻿using System;
using System.Collections.Generic;
using System.Text;


namespace DataModel
{
    public class JobGroupLevel
    {

        public int Id { get; set; }

        public string LevelValue { get; set; }  // ex. "01", "02"

        public int Active { get; set; } // ex : 0 = Level deleted, 1 = Level active


        public virtual ICollection<JobRole> JobRoles { get; set; }

        public virtual ICollection<JobGroupPosition> JobGroupPositions { get; set; }

        public virtual ICollection<JobRolePositionCompetency> JobRolePositionCompetencies { get; set; }


    }
}
