using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Admin.Data;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobGroups;

namespace Admin.Pages.Positions
{
    public class CreateModel : PageModel
    {
        private readonly DataModel.CctDbContext _context;

        private readonly JobCompetencyService _jobCompetencyService;

        public CreateModel(DataModel.CctDbContext context, JobCompetencyService jobCompetencyService)
        {
            _context = context;
            _jobCompetencyService = jobCompetencyService;
        }
        [BindProperty]
        public JobPosition JobPosition { get; set; }
        public List<JobCertificateDto> AddedCertificates = new List<JobCertificateDto>() { };
        public JobCompetencyDto[] JobCompetenciesKnowledge { get; set; }
        public JobCompetencyDto[] JobCompetenciesTechnical { get; set; }
        public JobCompetencyDto[] JobCompetenciesBehavioural { get; set; }
        public JobCompetencyDto[] JobCompetenciesExecutive { get; set; }
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings { get; set; } = new List<JobCompetencyRatingDto[]>();
        public List<JobCompetencyRatingDto> AddedKnowledgeCompetencies = new List<JobCompetencyRatingDto>() { };
        public List<JobCompetencyRatingDto> AddedTechnicalCompetencies = new List<JobCompetencyRatingDto>() { };
        public List<JobCompetencyRatingDto> AddedBehaviouralCompetencies = new List<JobCompetencyRatingDto>() { };
        public List<JobCompetencyRatingDto> AddedExecutiveCompetencies = new List<JobCompetencyRatingDto>() { };

        public JobGroupPositionDto[] JobGroupPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public int JobGroupId { get; set; } = 1;
        [BindProperty(SupportsGet = true)]
        public string TitleEng { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string TitleFre { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedCertificateIds { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedKnowledgeCompetencyIds { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedTechnicalCompetencyIds { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedBehaviouralCompetencyIds { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string AddedExecutiveCompetencyIds { get; set; } = string.Empty;
        [BindProperty]
        public JobGroupDto[] JobGroups { get; set; }
        public JobGroupDto CurrentSelectedJobGroup { get; set; }
        public JobCertificateDto[] JobCertificates { get; set; }
        public int JobHLCategory { get; set; }
        public List<int> SelectedRegionIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public int JobGroupLevelId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int SubJobGroupId { get; set; }
        [BindProperty]
        public string LevelCode { get; set; }
        [BindProperty]
        public string LevelValue { get; set; }
        [BindProperty]
        public string CertificateDescriptionid { get; set; }


        public async Task OnGetAsync()
        {
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobGroups = await _jobCompetencyService.GetJobGroups();
            CurrentSelectedJobGroup = JobGroups[0];
            JobGroupPositions = await _jobCompetencyService.GetSubGroupLevelsByGroupId(JobGroups[0].Id);

        }
        public async Task OnPostGroup()
        {
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobGroupPositions = await _jobCompetencyService.GetSubGroupLevelsByGroupId(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedKnowledgeCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    // var cidc = cid.Split("&")[0];
                    // var clevel = cid.Split("&")[1];

                    //   if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    // {
                    var cidInt = int.Parse(cid);

                    //  var cLevel = int.Parse(clevel);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    AddedCertificates.Add(certificateDto);

                    //}
                }
            }

        }
        public async Task OnPostCertificate()
        {

            var certificate = Request.Form["certificate"];
            //var level = Request.Form["knowledgeLevel"];
            //TitleEng = Request.Form["titleEng"];
            //TitleFre = Request.Form["titleFre"];
            AddedCertificateIds += certificate[0] + "-";
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetSubGroupLevelsByGroupId(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedKnowledgeCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    //var cidc = cid.Split("&")[0];
                    //var clevel = cid.Split("&")[1];

                    // if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    // {
                    var cidInt = int.Parse(cid);
                    //var cLevel = int.Parse(clevel);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    AddedCertificates.Add(certificateDto);
                    // }
                }
            }

        }
        public async Task OnPostCompetency(string competencytypename)
        {

            var Id = Request.Form[$"{competencytypename}Competency"];
            var level = Request.Form[$"{competencytypename}Level"];
            TitleEng = Request.Form["titleEng"];
            TitleFre = Request.Form["titleFre"];

            if (competencytypename == "knowledge")
            {
                AddedKnowledgeCompetencyIds += Id[0] + "&" + level[0] + "-";
            }
            else if (competencytypename == "technical")
            {
                AddedTechnicalCompetencyIds += Id[0] + "&" + level[0] + "-";
            }
            else if (competencytypename == "behavioural")
            {
                AddedBehaviouralCompetencyIds += Id[0] + "&" + level[0] + "-";
            }
            else if (competencytypename == "executive")
            {
                AddedExecutiveCompetencyIds += Id[0] + "&" + level[0] + "-";
            }
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetSubGroupLevelsByGroupId(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedKnowledgeCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedTechnicalCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedTechnicalCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedBehaviouralCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedBehaviouralCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedExecutiveCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedExecutiveCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    // var cidc = cid.Split("&")[0];
                    // var clevel = cid.Split("&")[1];

                    //   if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    // {
                    var cidInt = int.Parse(cid);

                    //  var cLevel = int.Parse(clevel);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    AddedCertificates.Add(certificateDto);

                    //}
                }
            }
        }

        public async Task OnPostDeleteCertificate(int certificateid)
        {

            //var Id = Request.Form["knowledgeCompetency"];
            //var level = Request.Form["knowledgeLevel"];
            //AddedKnowledgeCompetencyIds += Id[0] + "&" + level[0];
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            TitleEng = Request.Form["titleEng"];
            TitleFre = Request.Form["titleFre"];
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetSubGroupLevelsByGroupId(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    // var cidc = cid.Split("&")[0];
                    // var clevel = cid.Split("&")[1];

                    //   if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    // {
                    var cidInt = int.Parse(cid);
                    if (cidInt != certificateid)
                    {
                        //  var cLevel = int.Parse(clevel);
                        var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                        AddedCertificates.Add(certificateDto);
                    }
                    //}
                }
            }
            AddedCertificateIds = string.Empty;
            foreach (var certificate in AddedCertificates)
            {
                AddedCertificateIds += certificate.Id + "-";
            }
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedKnowledgeCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedBehaviouralCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedBehaviouralCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedTechnicalCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedTechnicalCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedExecutiveCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedExecutiveCompetencies.Add(competency);
                    }
                }
            }

        }
        public async Task OnPostDelete(int competencyid)
        {

            //var Id = Request.Form["knowledgeCompetency"];
            //var level = Request.Form["knowledgeLevel"];
            //AddedKnowledgeCompetencyIds += Id[0] + "&" + level[0];
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            TitleEng = Request.Form["titleEng"];
            TitleFre = Request.Form["titleFre"];
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetSubGroupLevelsByGroupId(JobGroupId);
            //JobGroupLevels = await _jobcategoryService.GetSubGroupLevelsByGroupId(id);
            //JobGroupPositions = string.IsNullOrEmpty(subgroupcode) ? await _jobcategoryService.GetJobGroupPositionsByLevel(id, level) : await _jobcategoryService.GetJobGroupPositionsBySubGroupLevel(id, subgroupcode, level);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    // var cidc = cid.Split("&")[0];
                    // var clevel = cid.Split("&")[1];

                    //   if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    // {
                    var cidInt = int.Parse(cid);

                    //  var cLevel = int.Parse(clevel);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    AddedCertificates.Add(certificateDto);

                    //}
                }
            }
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        if (cidInt != competencyid)
                        {
                            var cLevel = int.Parse(clevel);
                            var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                            AddedKnowledgeCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedBehaviouralCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        if (cidInt != competencyid)
                        {
                            var cLevel = int.Parse(clevel);
                            var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                            AddedBehaviouralCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedTechnicalCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        if (cidInt != competencyid)
                        {
                            var cLevel = int.Parse(clevel);
                            var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                            AddedTechnicalCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedExecutiveCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        if (cidInt != competencyid)
                        {
                            var cLevel = int.Parse(clevel);
                            var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                            AddedExecutiveCompetencies.Add(competency);
                        }
                    }
                }
            }
            AddedKnowledgeCompetencyIds = string.Empty;
            AddedTechnicalCompetencyIds = string.Empty;
            AddedBehaviouralCompetencyIds = string.Empty;
            AddedExecutiveCompetencyIds = string.Empty;
            foreach (var competency in AddedKnowledgeCompetencies)
            {
                AddedKnowledgeCompetencyIds += competency.CompetencyId + "&" + competency.RatingValue + "-";
            }
            foreach (var competency in AddedTechnicalCompetencies)
            {
                AddedTechnicalCompetencyIds += competency.CompetencyId + "&" + competency.RatingValue + "-";
            }
            foreach (var competency in AddedBehaviouralCompetencies)
            {
                AddedBehaviouralCompetencyIds += competency.CompetencyId + "&" + competency.RatingValue + "-";
            }
            foreach (var competency in AddedExecutiveCompetencies)
            {
                AddedExecutiveCompetencyIds += competency.CompetencyId + "&" + (competency.RatingValue + 5) + "-";
            }
        }
        public async Task<IActionResult> OnPostCreateAsync()
        {
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetSubGroupLevelsByGroupId(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            foreach (var cid in AddedKnowledgeCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedKnowledgeCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedTechnicalCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedTechnicalCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedBehaviouralCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedBehaviouralCompetencies.Add(competency);
                    }
                }
            }
            foreach (var cid in AddedExecutiveCompetencyIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidc = cid.Split("&")[0];
                    var clevel = cid.Split("&")[1];

                    if (!string.IsNullOrEmpty(cidc) && !string.IsNullOrEmpty(clevel))
                    {
                        var cidInt = int.Parse(cidc);
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        AddedExecutiveCompetencies.Add(competency);
                    }
                }
            }
            var jobPositionId = _jobCompetencyService.GetJobPositionIdByTitle(Request.Form["titleEng"]).Result;
            if (jobPositionId == 0)
            {
                var jobpositiondto = new JobPosition()
                {
                    TitleEng = Request.Form["titleEng"],
                    TitleFre = Request.Form["titleFre"],                   

                };
                _jobCompetencyService.PostJobPosition(jobpositiondto);
                jobPositionId = await _jobCompetencyService.GetJobPositionIdByTitle(TitleEng);
           
            var jobGroupPosition = new JobGroupPosition()
            {
                JobGroupId = JobGroupId,
                JobPositionId = jobPositionId,
                SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),


        };
             _jobCompetencyService.PostJobGroupPosition(jobGroupPosition);
            foreach(var competency in AddedKnowledgeCompetencies)
            {
                var jobrolepositioncompetency = new JobRolePositionCompetencyRating() { 
                    JobPositionId = jobPositionId,
                    
                CompetencyId = competency.CompetencyId,
                CompetencyLevelRequirementId = competency.CompetencyLevelRequirementId,
                CompetencyTypeId = 1,
                CompetencyRatingLevelId = competency.CompetencyRatingLevelId,
                    SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                    JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                JobGroupId = JobGroupId
                };

               _jobCompetencyService.PostJobRolePositionCompetency(jobrolepositioncompetency);
            }
                foreach (var competency in AddedTechnicalCompetencies)
                {
                    var jobrolepositioncompetency = new JobRolePositionCompetencyRating()
                    {
                        JobPositionId = jobPositionId,

                        CompetencyId = competency.CompetencyId,
                        CompetencyLevelRequirementId = competency.CompetencyLevelRequirementId,
                        CompetencyTypeId = 2,
                        CompetencyRatingLevelId = competency.CompetencyRatingLevelId,
                        SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                        JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                        JobGroupId = JobGroupId
                    };

                    _jobCompetencyService.PostJobRolePositionCompetency(jobrolepositioncompetency);
                }
                foreach (var competency in AddedBehaviouralCompetencies)
                {
                    var jobrolepositioncompetency = new JobRolePositionCompetencyRating()
                    {
                        JobPositionId = jobPositionId,

                        CompetencyId = competency.CompetencyId,
                        CompetencyLevelRequirementId = competency.CompetencyLevelRequirementId,
                        CompetencyTypeId = 3,
                        CompetencyRatingLevelId = competency.CompetencyRatingLevelId,
                        SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                        JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                        JobGroupId = JobGroupId
                    };

                    _jobCompetencyService.PostJobRolePositionCompetency(jobrolepositioncompetency);
                }
                foreach (var competency in AddedExecutiveCompetencies)
                {
                    var jobrolepositioncompetency = new JobRolePositionCompetencyRating()
                    {
                        JobPositionId = jobPositionId,

                        CompetencyId = competency.CompetencyId,
                        CompetencyLevelRequirementId = competency.CompetencyLevelRequirementId,
                        CompetencyTypeId = 4,
                        CompetencyRatingLevelId = competency.CompetencyRatingLevelId,
                        SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                        JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                        JobGroupId = JobGroupId
                    };

                    _jobCompetencyService.PostJobRolePositionCompetency(jobrolepositioncompetency);
                }
            }
            else
            {
                return Page();
            }
            /*
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Competencies.Add(Competency);
            await _context.SaveChangesAsync();
            */
            // string parameters = $"nameEng={Competency.NameEng}&nameFre={Competency.NameFre}&descEng={Competency.DescEng}&descFre={Competency.DescFre}";
            // try
            // {
            // _jobCompetencyService.PostJobCompetency(Competency);
            // }
            // catch(Exception ex) { 
            return RedirectToPage("Index");
            //   }
            //return Page();

        }
        private bool JobPositionExists(int id)

        {
            return _context.JobPositions.Any(e => e.Id == id);
        }
    }

}