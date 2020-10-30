using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataModel
{
    public class Certificate
    {
        
        public int Id { get; set; }

        public Competency Competency { get; set; }

        public string DescEng { get; set; }

        public string DescFre { get; set; }

        public string RequireIndicatorEng { get; set; }

        public string RequireIndicatorFre { get; set; }

    }
}
