using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class CompetencyGroupsType
    {
        public int CompetencyId { get; set; }

        public Competency Competency { get; set; }

        public int CompetencyTypeId { get; set; }

        public CompetencyType CompetencyType { get; set; }
    }
}
