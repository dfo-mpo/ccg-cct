using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class JobRole
    {
        public int JobGroupId { get; set; }

        public JobGroup JobGroup { get; set; } // ex:  AS, GT

        public int SubJobGroupId { get; set; }

        public SubJobGroup SubJobGroup { get; set; } // ex:  MOC, VHE, WOW

        public int JobGroupLevelId { get; set; }

        public JobGroupLevel JobGroupLevel { get; set; } // ex: 01, 02


    }
}