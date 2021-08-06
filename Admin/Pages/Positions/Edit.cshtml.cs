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
using Business.Dtos.JobPositions;
using System.Threading;

namespace Admin.Pages.Positions
{
    public class EditModel : PageModel
    {
        private readonly CctDbContext _context;

        private readonly JobCompetencyService _jobCompetencyService;

        public EditModel(CctDbContext context, JobCompetencyService jobCompetencyService)
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
        [BindProperty(SupportsGet = true)]
        public string TitleEng { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string TitleFre { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string DescriptionEng { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public string DescriptionFre { get; set; } = string.Empty;
        public List<JobCompetencyRatingDto[]> PositionCompetencyRatings { get; set; } = new List<JobCompetencyRatingDto[]>();
        public List<JobCompetencyRatingDto> AddedKnowledgeCompetencies = new List<JobCompetencyRatingDto>() { };
        public List<JobCompetencyRatingDto> AddedTechnicalCompetencies = new List<JobCompetencyRatingDto>() { };
        public List<JobCompetencyRatingDto> AddedBehaviouralCompetencies = new List<JobCompetencyRatingDto>() { };
        public List<JobCompetencyRatingDto> AddedExecutiveCompetencies = new List<JobCompetencyRatingDto>() { };
        [BindProperty]
        public JobCertificateDto[] JobCertificateDescriptions { get; set; }
        public JobGroupPositionDto[] JobGroupPositions { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public int JobGroupId { get; set; } = 2;
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
        [BindProperty(SupportsGet = true)]
        public string RegionIds { get; set; } = string.Empty;
        [BindProperty]
        public JobGroupDto[] JobGroups { get; set; }
        [BindProperty]
        public JobPositionDto CurrentJobPosition { get; set; }
        public JobGroupDto CurrentSelectedJobGroup { get; set; }
        public JobCertificateDto[] JobCertificates { get; set; }
        [BindProperty(SupportsGet = true)]
        public string JobHLCategory { get; set; } = string.Empty;
        [BindProperty]
        public List<string> SelectedRegionIds { get; set; } = new List<string> { };
        [BindProperty(SupportsGet = true)]
        public int JobGroupLevelId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int SubJobGroupId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelCode { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LevelValue { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {

            JobPosition = await _context.JobPositions.FirstOrDefaultAsync(m => m.Id == id);
            if (JobPosition == null)
            {
                return NotFound();
            }

            TitleEng = JobPosition.TitleEng;
            TitleFre = JobPosition.TitleFre;
            DescriptionEng = JobPosition.PositionDescEng;
            DescriptionFre = JobPosition.PositionDescFre;

            CurrentJobPosition = await _jobCompetencyService.GetJobPositionById(id);
            var PositionCertificates = await _jobCompetencyService.GetJobCertificatesById(id);
            var jobHLCategory = await _jobCompetencyService.GetJobPositionHLCategoryIdByPositionId(id);
            JobHLCategory = jobHLCategory.ToString();
            var selectedRegionIds = await _jobCompetencyService.GetJobLocationRegionsById(id);
            foreach (var rid in selectedRegionIds)
            {
                RegionIds += rid.JobLocationRegionId.ToString() + "-";
                SelectedRegionIds.Add(rid.ToString());
            }
            if (PositionCertificates != null)
            {
                foreach (var certificate in PositionCertificates)
                {
                    AddedCertificateIds += certificate.Id + "&" + certificate.CertificateDescId + "-";
                    if (certificate != null)
                    {
                        AddedCertificates.Add(certificate);
                    }
                }
            }
            var competenciesType1 = await _jobCompetencyService.GetJobCompetencyRatingsByTypeId(id, 1);
            if (competenciesType1 != null)
            {
                foreach (var competency in competenciesType1)
                {
                    AddedKnowledgeCompetencyIds += competency.CompetencyId + "&" + competency.CompetencyLevelRequirementId + "-";
                    var competencyDto = await _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(competency.CompetencyId, competency.CompetencyLevelRequirementId);
                    if (competencyDto != null)
                    {
                        AddedKnowledgeCompetencies.Add(competencyDto);
                    }
                }
            }

            var competenciesType2 = await _jobCompetencyService.GetJobCompetencyRatingsByTypeId(id, 2);
            if (competenciesType2 != null)
            {
                foreach (var competency in competenciesType2)
                {
                    AddedTechnicalCompetencyIds += competency.CompetencyId + "&" + competency.CompetencyLevelRequirementId + "-";
                    var competencyDto = await _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(competency.CompetencyId, competency.CompetencyLevelRequirementId);
                    if (competencyDto != null)
                    {
                        AddedTechnicalCompetencies.Add(competencyDto);
                    }
                }
            }

            var competenciesType3 = await _jobCompetencyService.GetJobCompetencyRatingsByTypeId(id, 3);
            if (competenciesType3 != null)
            {
                foreach (var competency in competenciesType3)
                {
                    AddedBehaviouralCompetencyIds += competency.CompetencyId + "&" + competency.CompetencyLevelRequirementId + "-";
                    var competencyDto = await _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(competency.CompetencyId, competency.CompetencyLevelRequirementId);
                    if (competencyDto != null)
                    {
                        AddedBehaviouralCompetencies.Add(competencyDto);
                    }
                }
            }

            var competenciesType4 = await _jobCompetencyService.GetJobCompetencyRatingsByTypeId(id, 4);
            if (competenciesType4 != null)
            {
                foreach (var competency in competenciesType4)
                {
                    AddedExecutiveCompetencyIds += competency.CompetencyId + "&" + competency.CompetencyLevelRequirementId + "-";
                    var competencyDto = await _jobCompetencyService.GetJobCompetencyLevelRequirementDescriptionByIdLevelValue(competency.CompetencyId, competency.CompetencyLevelRequirementId);
                    if (competencyDto != null)
                    {
                        AddedExecutiveCompetencies.Add(competencyDto);
                    }
                }
            }


            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            JobGroupId = CurrentJobPosition.JobGroupId;
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(CurrentJobPosition.JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            SubJobGroupId = CurrentJobPosition.SubJobGroupId;
            JobGroupLevelId = CurrentJobPosition.JobGroupLevelId;
            LevelCode = CurrentJobPosition.LevelCode;
            return Page();

        }
        public async Task OnPostGroup()
        {
            JobPosition = await _context.JobPositions.FirstOrDefaultAsync(m => m.Id == Id);
            CurrentJobPosition = await _jobCompetencyService.GetJobPositionById(Id);
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            SubJobGroupId = JobGroupPositions.FirstOrDefault().SubJobGroupId;
            JobGroupLevelId = JobGroupPositions.FirstOrDefault().LevelId;
            LevelCode = JobGroupPositions.FirstOrDefault().LevelCode;
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds)
            {
                RegionIds += id + "-";
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
                        if (competency != null)
                        {
                            AddedKnowledgeCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedTechnicalCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedBehaviouralCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedExecutiveCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    certificateDto.CertificateDescId = int.Parse(cid.Split("&")[1]);
                    AddedCertificates.Add(certificateDto);
                }
            }

        }
        public async Task OnPostCertificate()
        {
            JobPosition = await _context.JobPositions.FirstOrDefaultAsync(m => m.Id == Id);
            CurrentJobPosition = await _jobCompetencyService.GetJobPositionById(Id);
            var certificate = Request.Form["certificate"];
            var certificatedescId = Request.Form["CertificateDescriptionId"];
            AddedCertificateIds += certificate[0] + "&" + certificatedescId[0] + "-";
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            SubJobGroupId = int.Parse(LevelValue.Split("/")[0]);
            JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]);
            LevelCode = LevelValue.Split("/")[2];
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds)
            {
                RegionIds += id + "-";
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
                        if (competency != null)
                        {
                            AddedKnowledgeCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedTechnicalCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedBehaviouralCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedExecutiveCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    certificateDto.CertificateDescId = int.Parse(cid.Split("&")[1]);
                    AddedCertificates.Add(certificateDto);
                }
            }

        }
        public async Task OnPostCompetency(string competencytypename)
        {
            JobPosition = await _context.JobPositions.FirstOrDefaultAsync(m => m.Id == this.Id);
            CurrentJobPosition = await _jobCompetencyService.GetJobPositionById(this.Id);
            var Id = Request.Form[$"{competencytypename}Competency"];
            var level = Request.Form[$"{competencytypename}Level"];
            TitleEng = Request.Form["titleEng"];
            TitleFre = Request.Form["titleFre"];
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds)
            {
                RegionIds += id + "-";
            }
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
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            SubJobGroupId = int.Parse(LevelValue.Split("/")[0]);
            JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]);
            LevelCode = LevelValue.Split("/")[2];
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
                        if (competency != null)
                        {
                            AddedKnowledgeCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedTechnicalCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedBehaviouralCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedExecutiveCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    certificateDto.CertificateDescId = int.Parse(cid.Split("&")[1]);
                    AddedCertificates.Add(certificateDto);
                }
            }
        }

        public async Task OnPostDeleteCertificate(int certificateid)
        {
            JobPosition = await _context.JobPositions.FirstOrDefaultAsync(m => m.Id == Id);
            CurrentJobPosition = await _jobCompetencyService.GetJobPositionById(Id);
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            TitleEng = Request.Form["titleEng"];
            TitleFre = Request.Form["titleFre"];
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            SubJobGroupId = int.Parse(LevelValue.Split("/")[0]);
            JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]);
            LevelCode = LevelValue.Split("/")[2];
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds)
            {
                RegionIds += id + "-";
            }
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    if (cidInt != certificateid)
                    {
                        var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                        certificateDto.CertificateDescId = int.Parse(cid.Split("&")[1]);
                        AddedCertificates.Add(certificateDto);
                    }
                }
            }
            AddedCertificateIds = string.Empty;
            foreach (var certificate in AddedCertificates)
            {
                AddedCertificateIds += certificate.Id + "&" + certificate.CertificateDescId + "-";
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
                        if (competency != null)
                        {
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedExecutiveCompetencies.Add(competency);
                        }
                    }
                }
            }

        }
        public async Task OnPostDelete(int competencyid)
        {
            JobPosition = await _context.JobPositions.FirstOrDefaultAsync(m => m.Id == Id);
            CurrentJobPosition = await _jobCompetencyService.GetJobPositionById(Id);
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            TitleEng = Request.Form["titleEng"];
            TitleFre = Request.Form["titleFre"];
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            SubJobGroupId = int.Parse(LevelValue.Split("/")[0]);
            JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]);
            LevelCode = LevelValue.Split("/")[2];
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds)
            {
                RegionIds += id + "-";
            }
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    certificateDto.CertificateDescId = int.Parse(cid.Split("&")[1]);
                    AddedCertificates.Add(certificateDto);
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
                            if (competency != null)
                            {
                                AddedKnowledgeCompetencies.Add(competency);
                            }
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
                            if (competency != null)
                            {
                                AddedBehaviouralCompetencies.Add(competency);
                            }
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
                            if (competency != null)
                            {
                                AddedTechnicalCompetencies.Add(competency);
                            }
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
                            if (competency != null)
                            {
                                AddedExecutiveCompetencies.Add(competency);
                            }
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
            if (!ModelState.IsValid)
            {
                return Page();
            }
            JobPosition = await _context.JobPositions.FirstOrDefaultAsync(m => m.Id == Id);
            CurrentJobPosition = await _jobCompetencyService.GetJobPositionById(Id);
            JobCertificates = await _jobCompetencyService.GetJobCertificates();
            JobCompetenciesKnowledge = await _jobCompetencyService.GetJobCompetenciesByTypeId(1);
            JobCompetenciesTechnical = await _jobCompetencyService.GetJobCompetenciesByTypeId(2);
            JobCompetenciesBehavioural = await _jobCompetencyService.GetJobCompetenciesByTypeId(3);
            JobCompetenciesExecutive = await _jobCompetencyService.GetJobCompetenciesByTypeId(4);
            CurrentSelectedJobGroup = await _jobCompetencyService.GetJobGroupById(JobGroupId);
            JobGroupPositions = await _jobCompetencyService.GetJobGroupPositionLevelsById(JobGroupId);
            JobGroups = await _jobCompetencyService.GetJobGroups();
            JobCertificateDescriptions = await _jobCompetencyService.GetAllJobCertificateDescriptions();
            LevelCode = LevelValue.Split("/")[2];
            RegionIds = string.Empty;
            foreach (var id in SelectedRegionIds)
            {
                RegionIds += id + "-";
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
                        if (competency != null)
                        {
                            AddedKnowledgeCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedTechnicalCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedBehaviouralCompetencies.Add(competency);
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
                        var cLevel = int.Parse(clevel);
                        var competency = await _jobCompetencyService.GetJobCompetencyLevelByIdLevelId(cidInt, cLevel);
                        if (competency != null)
                        {
                            AddedExecutiveCompetencies.Add(competency);
                        }
                    }
                }
            }
            foreach (var cid in AddedCertificateIds.Split("-"))
            {
                if (!string.IsNullOrEmpty(cid))
                {
                    var cidInt = int.Parse(cid.Split("&")[0]);
                    var certificateDto = await _jobCompetencyService.GetJobCertificateById(cidInt);
                    if (certificateDto != null)
                    {
                        certificateDto.CertificateDescId = int.Parse(cid.Split("&")[1]);
                        AddedCertificates.Add(certificateDto);
                    }
                }
            }

            var jobgrouppositions = _context.JobGroupPositions.Where(e => e.JobPositionId == JobPosition.Id).ToList();
            _context.JobGroupPositions.RemoveRange(jobgrouppositions);
            var jobrolepositioncertificates = _context.JobRolePositionCertificates.Where(e => e.JobPositionId == JobPosition.Id).ToList();
            _context.JobRolePositionCertificates.RemoveRange(jobrolepositioncertificates);
            var jobpositioncompetencies = _context.JobPositionCompetencies.Where(e => e.JobPositionId == JobPosition.Id).ToList();
            _context.JobPositionCompetencies.RemoveRange(jobpositioncompetencies);
            var jobrolepositioncompetencies = _context.JobRolePositionCompetencies.Where(e => e.JobPositionId == JobPosition.Id).ToList();
            _context.JobRolePositionCompetencies.RemoveRange(jobrolepositioncompetencies);
            var jobrolepositioncompetencyratings = _context.JobRolePositionCompetencyRatings.Where(e => e.JobPositionId == JobPosition.Id).ToList();
            _context.JobRolePositionCompetencyRatings.RemoveRange(jobrolepositioncompetencyratings);
            var jobrolepositionhlcategories = _context.JobRolePositionHLCategories.Where(e => e.JobPositionId == JobPosition.Id).ToList();
            _context.JobRolePositionHLCategories.RemoveRange(jobrolepositionhlcategories);
            var jobrolepositionlocations = _context.JobRolePositionLocations.Where(e => e.JobPositionId == JobPosition.Id).ToList();
            _context.JobRolePositionLocations.RemoveRange(jobrolepositionlocations);
            _context.SaveChanges();

            _jobCompetencyService.UpdateJobPosition(new JobPosition()
            {
                Id = JobPosition.Id,
                TitleEng = TitleEng,
                TitleFre = TitleFre,
                PositionDescEng = DescriptionEng,
                PositionDescFre = DescriptionFre
            });
            var jobGroupPosition = new JobGroupPosition()
            {
                JobGroupId = JobGroupId,
                JobPositionId = JobPosition.Id,
                SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
            };
            _jobCompetencyService.PostJobGroupPosition(jobGroupPosition);
            foreach (var competency in AddedKnowledgeCompetencies)
            {
                var jobrolepositioncompetency = new JobRolePositionCompetencyRating()
                {
                    JobPositionId = JobPosition.Id,
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
                    JobPositionId = JobPosition.Id,

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
                    JobPositionId = JobPosition.Id,
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
                    JobPositionId = JobPosition.Id,
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
            foreach (var id in SelectedRegionIds)
            {
                var jobrolepositionlocation = new JobRolePositionLocation()
                {
                    JobLocationRegionId = int.Parse(id),
                    JobGroupId = JobGroupId,
                    JobPositionId = JobPosition.Id,
                    SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                    JobGroupLevelId = int.Parse(LevelValue.Split("/")[1])
                };
                _jobCompetencyService.PostJobRolePositionLocation(jobrolepositionlocation);
            }

            var jobrolepositionhlcategory = new JobRolePositionHLCategory()
            {
                JobGroupId = JobGroupId,
                JobPositionId = JobPosition.Id,
                SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                JobHLCategoryId = int.Parse(JobHLCategory)
            };
            _jobCompetencyService.PostJobRolePositionHLCategory(jobrolepositionhlcategory);
            foreach (var certificate in AddedCertificates)
            {
                var jobrolepositioncertificate = new JobRolePositionCertificate()
                {
                    JobPositionId = JobPosition.Id,
                    JobGroupId = JobGroupId,
                    SubJobGroupId = int.Parse(LevelValue.Split("/")[0]),
                    JobGroupLevelId = int.Parse(LevelValue.Split("/")[1]),
                    CertificateDescriptionId = certificate.CertificateDescId,
                    CertificateId = certificate.Id,
                };
                _jobCompetencyService.PostJobRolePositionCertificate(jobrolepositioncertificate);

            }

            Thread.Sleep(10000);
            return RedirectToPage("Details", new { positionid = JobPosition.Id, });

        }
    }
}
