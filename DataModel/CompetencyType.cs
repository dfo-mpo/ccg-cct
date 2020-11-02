﻿using System;
using System.Collections.Generic;
using System.Text;


namespace DataModel
{
    public class CompetencyType
    {
        public int Id { get; set; }

        public string NameEng { get; set; }

        public string NameFre { get; set; }

        public virtual ICollection<CompetencyTypeGroup> CompetencyTypeGroups { get; set; } 
    }
}
