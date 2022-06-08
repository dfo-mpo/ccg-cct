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

        [Display(Name = "Name English")]
        [MaxLength(1000)]
        public string NameEng { get; set; } // ex : Master 150 GT Domestic

        [Display(Name = "Name French")]
        [MaxLength(1000)]
        public string NameFre { get; set; }

        [Display(Name = "Description English")]
        [MaxLength(1000)]
        public string DescEng { get; set; }

        [Display(Name = "Description French")]
        [MaxLength(1000)]
        public string DescFre { get; set; }

        public int Active { get; set; } // ex : 0 = certificate deleted, 1 = certificate active

        public virtual ICollection<JobRolePositionCertificate> JobRolePositionCertificates { get; set; }

    }
}
