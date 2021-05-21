using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<JobGroup> JobGroups = new List<JobGroup>()
        {
            new JobGroup {Id = 1, Code = "GT", NameEng = "General Technician", NameFre = "Techniciens divers", Active = 1 },
            new JobGroup {Id = 2, Code = "AS", NameEng = "Administrative Services", NameFre = "Services administratif", Active = 1 },
            new JobGroup {Id = 3, Code = "CS", NameEng = "Computer Systems", NameFre = "Systèmes d'ordinateurs", Active = 1 },
            new JobGroup {Id = 4, Code = "GS", NameEng = "General Services", NameFre = "Services divers", Active = 1 },
            new JobGroup {Id = 5, Code = "LI", NameEng = "Lightkeepers", NameFre = "Gardiens de phares", Active = 1 },
            new JobGroup {Id = 6, Code = "EG", NameEng = "Engineering and Scientific Support", NameFre = "Soutien technologique et scientifique", Active = 1 },
            new JobGroup {Id = 7, Code = "PG", NameEng = "Purchasing and Supply", NameFre = "Achat et approvisionnement", Active = 1 },
            new JobGroup {Id = 8, Code = "GL", NameEng = "General Labour and Trades", NameFre = "Manœuvres et hommes de métier", Active = 1 },
            new JobGroup {Id = 9, Code = "SC", NameEng = "Ships' Crews", NameFre = "Équipages de navires", Active = 1 },
            new JobGroup {Id = 10, Code = "SO", NameEng = "Ships' Officers", NameFre = "Officiers et officières de navire", Active = 1 },
            new JobGroup {Id = 11, Code = "ENG", NameEng = "Architecture, Engineering", NameFre = "Architecture et Ingénierie", Active = 1 },
            new JobGroup {Id = 13, Code = "EC", NameEng = "Economics and Social Science Services", NameFre = "Économique et services de sciences sociales", Active = 1 },
            new JobGroup {Id = 14, Code = "ED", NameEng = "Education Services", NameFre = "Services de l’enseignement", Active = 1 },
            new JobGroup {Id = 15, Code = "EU", NameEng = "Educational Support", NameFre = "Soutien de l’enseignement", Active = 1 },
            new JobGroup {Id = 16, Code = "EX", NameEng = "Executive Group", NameFre = "Groupe exécutif", Active = 1 },
            new JobGroup {Id = 17, Code = "LS", NameEng = "Library Science", NameFre = "Bibliothéconomie", Active = 1 },
            new JobGroup {Id = 18, Code = "NU", NameEng = "Nursing", NameFre = "Infirmières", Active = 1 },
            new JobGroup {Id = 19, Code = "OE", NameEng = "Office Equipment", NameFre = "Mécanographie", Active = 1 },
            new JobGroup {Id = 20, Code = "PM", NameEng = "Programme Administration", NameFre = "Administration des programmes", Active = 1 },
            new JobGroup {Id = 21, Code = "RO", NameEng = "Radio Operations", NameFre = "Radiotélégraphie", Active = 1 },
            new JobGroup {Id = 22, Code = "TI", NameEng = "Technical Inspection", NameFre = "Inspection technique", Active = 1 },
            new JobGroup {Id = 23, Code = "EL", NameEng = "Electronics", NameFre = "Électronique", Active = 1 }
        };
    }
}
