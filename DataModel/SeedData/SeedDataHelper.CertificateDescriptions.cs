﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<CertificateDescription> CertificateDescriptions = new List<CertificateDescription>()
            {
                new CertificateDescription { Id = 1, DescEng = "lorem ipsum", DescFre ="lorem ipsum"},
                new CertificateDescription { Id = 2, DescEng = "with Limited Contiguous Endorsement", DescFre ="avec Attestation de voyage limité, contiguës"},
                new CertificateDescription { Id = 3, DescEng = "with Master 150GT, Domestic", DescFre ="avec Capitaine, jauge brute de 150, navigation intérieure"},
                new CertificateDescription { Id = 4, DescEng = "and Unlimited ACV Endorsement", DescFre ="et Attestation de VCA illimité"},
                new CertificateDescription { Id = 5, DescEng = "(Depending on location, voyage and ship class this certificate may be substituted)", DescFre ="(Selon l'emplacement, le voyage et la classe du navire, ce certificat peut être remplacé)"},
                new CertificateDescription { Id = 6, DescEng = "(Dependant on position and training course)", DescFre ="(Dépend du poste et du cours de formation)"},
                new CertificateDescription { Id = 7, DescEng = "(Depending on background and shop specialty this certificate may be substituted)", DescFre ="(Selon l'expérience et la spécialité de l'atelier, ce certificat peut être remplacé)"},
                new CertificateDescription { Id = 8, DescEng = "(Depending on background and shop specialty these certificates may be substituted)", DescFre ="(Selon les antécédents et la spécialité de l'atelier, ces certificats peuvent être remplacés)"},
                new CertificateDescription { Id = 9, DescEng = "(Depending on location these certificates may be substituted)", DescFre ="(Selon l'emplacement, ces certificats peuvent être remplacés)"},
                new CertificateDescription { Id = 10, DescEng = "(under training)", DescFre ="(en formation)"},
                new CertificateDescription { Id = 11, DescEng = "(or Watchkeeping Mate, Near Coastal for MSPVs)", DescFre ="(ou Officier de pont de quart, à proximité du littoral pour NHRH)"},
                new CertificateDescription { Id = 12, DescEng = "(or Master 3000GT for Great Lakes/Mackenzie River)", DescFre ="(ou Capitaine, jauge brute de 3 000 pour les Grands Lacs et la rivière Mackenzie)"},
                new CertificateDescription { Id = 13, DescEng = "(or Master Mariner depending on voyage)", DescFre ="(ou Capitaine au long cours, selon le voyage)"},
            };


    }
}