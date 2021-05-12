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

        public string NameEng { get; set; }

        public string NameFre { get; set; }

        public string DescEng { get; set; }

        public string DescFre { get; set; }
        
        public int Active { get; set; }
        public virtual ICollection<JobRolePositionCertificate> JobRolePositionCertificates { get; set; }

    }
}
