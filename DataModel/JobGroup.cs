﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class JobGroup
    {
        // Primary Key
        public int JobGroupId { get; set; }

        // Properties
        public string JobGroupClassification { get; set; }

        // entity will hold all of the JobRoles entities that are related to that JobGroup entity.
        public virtual ICollection<JobRoles> JobRoles { get; set; }

        // entity will hold all of the JobPosition entities that are related to that JobGroup entity.
        public virtual ICollection<JobPosition> JobPosition { get; set; }

        // entity will hold all of the JobGroupPosition entities that are related to thatJobGroup entity.
        public virtual ICollection<JobGroupPosition> JobGroupPosition { get; set; }

    }
}
