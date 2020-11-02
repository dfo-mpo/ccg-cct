using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class JobPositionCompetency
    {
        public int JobPositionId { get; set; }

        public JobPosition JobPosition { get; set; }

        public int CompetencyId { get; set; }

        public Competency Competency { get; set; }

    }
}
