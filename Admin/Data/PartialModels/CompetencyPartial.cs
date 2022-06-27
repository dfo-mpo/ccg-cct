using Business.Dtos.JobPositions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Admin.Data;
using Microsoft.Extensions.Logging;
using Business.Dtos.JobGroups;
using System.Threading;
using Admin.Pages.Similar;
using Business.Dtos.JobCompetencies;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Admin.Pages.Positions;

namespace Admin.Data.PartialModels
{
    public class CompetencyPartialModel
    {

        public string FullCompetencyNameEng { get; set; }

        public string FullCompetencyNameFre { get; set; }

        public string FullCompetencyNameOneWord { get; set; }

        public string ShortCompetencyName { get; set; }

        public JobCompetencyDto[] FullCompetencyList { get; set; }

        public List<JobCompetencyRatingDto> AddedCompetenciesList { get; set; }

        public bool ExpandableItemsOpenNewWindows { get; set; }

        public int AmountToAddToCompetencyRating { get; set; }

        public Pages.Positions.EditModel FullModel { get; set; }

        public Dictionary<string, string> RouteDataForCompetency { get; set; }

        public bool UseAn { get; set; } = false;

        public bool UseElement { get; set; } = true;

    }
}
