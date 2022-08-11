using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Business.Dtos.CustomValidationForDtos;

namespace Business.Dtos.JobCompetencies
{
    public class JobCertificateDto
    {
        public int Id { get; set; }
        public int CertificateDescId { get; set; }

        [Display(Name = "Name English")]
        [MaxLength(1000)]
        public string NameEng { get; set; }

        [Display(Name = "Name French")]
        [MaxLength(1000)]
        public string NameFre { get; set; }

        [Display(Name = "Description English")]
        [MaxLength(1000)]
        [BothOrNone("DescFre", "Both descriptions must be provided if one is filled out")]
        public string DescEng { get; set; }

        [Display(Name = "Description French")]
        [MaxLength(1000)]
        public string DescFre { get; set; }

        public string CertificateDescEng { get; set; } // this corresponds to the description that is unique to the certificate, not the selected one (if applicable)

        public string CertificateDescFre { get; set; }

        public int Active { get; set; }
    }
}