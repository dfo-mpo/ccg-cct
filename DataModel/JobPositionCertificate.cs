using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    public class JobPositionCertificate
    {
        public int JobPositionId { get; set; }

        public JobPosition JobPosition { get; set; }

        public int CertificateId { get; set; }

        public Certificate Certificate { get; set; }
    }
}
