﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    public class JobRolePositionCertificate
    {
        public int JobGroupId { get; set; }

        public JobGroup JobGroup { get; set; }

        public int SubJobGroupId { get; set; }

        public SubJobGroup SubJobGroup { get; set; }

        public int JobGroupLevelId { get; set; }

        public JobGroupLevel JobGroupLevel { get; set; }

        public int JobPositionId { get; set; }

        public JobPosition JobPosition { get; set; }

        public int CertificateId { get; set; }

        public Certificate Certificate { get; set; }

        public int CertificateDescriptionId { get; set; }

        public CertificateDescription CertificateDescription { get; set; }
    }
}
