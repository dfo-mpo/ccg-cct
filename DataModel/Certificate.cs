using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    public class Certificate
    {
        
        public int Id { get; set; }

        public int CompetencyId { get; set; }

        public Competency Competency { get; set; }

        public string RequireIndicatorEng { get; set; }

        public string RequireIndicatorFre { get; set; }

    }
}
