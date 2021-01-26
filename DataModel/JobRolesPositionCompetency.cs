﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class JobRolesPositionCompetency
    {
        public int JobGroupId { get; set; }

        public JobGroup JobGroup { get; set; }

        public int JobGroupLevelId { get; set; }

        public JobGroupLevel JobGroupLevel { get; set; }

        public int JobPositionId { get; set; }

        public JobPosition JobPosition { get; set; }

        public int CompetencyId { get; set; }

        public Competency Competency { get; set; }
    }
}