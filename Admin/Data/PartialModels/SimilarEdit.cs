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

namespace Admin.Data.PartialModels
{
    public class SimilarEditPartialModel
    {

        public JobPositionDto[] JobPositions { get; set; } 

        public EditModel EditModel { get; set; }

        public CreateModel CreateModel { get; set; }

        public bool IsInEditMode { get; set; } = true;

        public int PercentMatch { get; set; }

        public int JobPositionId { get; set; }

        public Dictionary<string, string> RouteDataAdd { get; set; }

        public string LevelCode { get; set; }

        public string LevelValue { get; set; }

        public string OneHundredPercentIds { get; set; }

        public string NinetyPercentIds { get; set; }

        public string EightyPercentIds { get; set; }

        public string SeventyPercentIds { get; set; }

        public int JobGroupId { get; set; }

        public string SubGroupCode { get; set; }

        public int SubJobGroupId { get; set; }

        public int JobGroupLevelId { get; set; }

        public JobGroupDto[] JobGroups { get; set; }

        public JobGroupPositionDto[] JobGroupPositions { get; set; }

        public JobPositionDto[] JobGroupLevelPositions { get; set; } = new JobPositionDto[] { };

        public List<JobPositionDto> AllActiveJobs { get; set; }

        public JobGroupDto CurrentSelectedJobGroup { get; set; }

        public string CurrentSelectedLevelCode { get; set; }

        public JobPositionDto CurrentSelectedPosition { get; set; }

    }
}
