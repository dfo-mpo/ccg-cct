using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class CompetencyType
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string NameEng { get; set; } // Certificate, KE, TE, BE

        [StringLength(150)]
        public string NameFre { get; set; }

        // entity will hold all of the CompetencyGroupsTypes entities that are related to that CompetencyType entity.
        public virtual ICollection<CompetencyGroupsType> CompetencyGroupsType { get; set; } 
    }
}
