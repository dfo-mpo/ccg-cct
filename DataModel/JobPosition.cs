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

        public string TitleEng { get; set; } // ex: Manager, IT advisor

        public string TitleFre { get; set; }

        public virtual ICollection<JobPositionCompetency> JobPositionCertCompetencies { get; set; }

        
    }
}
