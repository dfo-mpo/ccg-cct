using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class CertificateDescription
    {
        public int Id { get; set; }

        [Display(Name = "Description English")]
        [MaxLength(1000)]
        [Required]
        public string DescEng { get; set; }

        [Display(Name = "Description French")]
        [MaxLength(1000)]
        [Required]
        public string DescFre { get; set; }

        public int Active { get; set; } // ex : 0 = certificate Description deleted, 1 = certificate Description active

        public virtual ICollection<JobRolePositionCertificate> JobRolePositionCertificates { get; set; }


    }
}