﻿using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Dtos.JobCompetencies
{
    public class JobCompetencyDto
    {
        public int Id { get; set; }
        public int Active { get; set; }
        public int TypeId { get; set; }

        [Display(Name = "Type Name English")]
        public string TypeNameEng { get; set; }

        [Display(Name = "Type Name French")]
        public string TypeNameFre { get; set; }

        [Display(Name = "Name English")]
        public string NameEng { get; set; }

        [Display(Name = "Name French")]
        public string NameFre { get; set; }

        [Display(Name = "Description English")]
        public string DescEng { get; set; }

        [Display(Name = "Description French")]
        public string DescFre { get; set; }
        public string Level1DescEng { get; set; }
        public string Level1DescFre { get; set; }
        public string Level2DescEng { get; set; }
        public string Level2DescFre { get; set; }
        public string Level3DescEng { get; set; }
        public string Level3DescFre { get; set; }
        public string Level4DescEng { get; set; }
        public string Level4DescFre { get; set; }
        public string Level5DescEng { get; set; }
        public string Level5DescFre { get; set; }
    }
}