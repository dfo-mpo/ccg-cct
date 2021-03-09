using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<CompetencyRatingLevel> CompetencyRatingLevel = new List<CompetencyRatingLevel>()
        {
            new CompetencyRatingLevel
            {
                Id = 1, Value = 1, NameEng = "Fundamental Awareness", NameFre = "Connaissance élémentaire",
                DescEng = "(Common knowledge or an understanding of basic techniques and concepts)",
                DescFre = "(connaissances communes ou compréhension des techniques et des concepts de base)"
            },
            new CompetencyRatingLevel
            {
                Id = 2, Value = 2, NameEng = "Novice", NameFre = "Débutant",
                DescEng = "(A level of experience has been obtained; may need help when performing a task/skill)",
                DescFre = "(une certaine expérience a été accumulée; peut avoir besoin d’aide pour l’exécution d’une tâche ou l’application d’une compétence)"
            },
            new CompetencyRatingLevel
            {
                Id = 3, Value = 3, NameEng = "Intermediate", NameFre = "Intermédiaire",
                DescEng = "(Able to successfully complete the necessary tasks in this competency. Some assistance may still be needed but can usually perform the task independently)",
                DescFre = "(capable de mener à bien les tâches nécessaires liées à cette compétence. La personne peut encore avoir besoin d’une certaine assistance, mais peut généralement accomplir la tâche de manière indépendante)"
            },
            new CompetencyRatingLevel
            {
                Id = 4, Value = 4, NameEng = "Advanced", NameFre = "Avancé",
                DescEng = "(Performs the actions associated with this skill without assistance. Able to provide assistance to other colleagues when questions arise regarding this skill)",
                DescFre = "(capable d’exécuter correctement et sans aide les tâches associées à la compétence. Capable de fournir une aide à des collègues lorsque des questions sont posées concernant cette compétence)"
            },
            new CompetencyRatingLevel
            {
                Id = 5, Value = 5, NameEng = "Expert", NameFre = "Expert",
                DescEng = "(Provides guidance, troubleshoot, and answer questions related to this area of expertise and the field where the skill is used)",
                DescFre = "(prestation de conseils, correction des problèmes et réponse aux questions liées à ce domaine d’expertise et au champ dans le cadre duquel la compétence est utilisée)"
            },
            new CompetencyRatingLevel
            {
                Id = 6, Value = 1, NameEng = "Director Level", NameFre = "Niveau du directeur",
                DescEng = "",
                DescFre = ""
            },
            new CompetencyRatingLevel
            {
                Id = 7, Value = 2, NameEng = "Senior Director / Executive Director Level", NameFre = "Niveau de directeur principal / directeur exécutif",
                DescEng = "",
                DescFre = ""
            },
            new CompetencyRatingLevel
            {
                Id = 8, Value = 3, NameEng = "Director General Level", NameFre = "Niveau directeur général",
                DescEng = "",
                DescFre = ""
            },
            new CompetencyRatingLevel
            {
                Id = 9, Value = 4, NameEng = "Deputy Commissioner / Assistant Deputy Minister Level", NameFre = "Niveau de sous-commissaire / sous-ministre adjoint",
                DescEng = "",
                DescFre = ""
            },
            new CompetencyRatingLevel
            {
                Id = 10, Value = 5, NameEng = "Commissioner / Deputy Minister Level", NameFre = "Niveau du commissaire / sous-ministre",
                DescEng = "",
                DescFre = ""
            }
        };
    }
}